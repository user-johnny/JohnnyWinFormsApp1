using Dapper;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace JohnnyWinFormsApp1
{
    public partial class Form1 : Form
    {
        string SqlStr = @"server=192.168.1.9;database=master;uid=SYSADM;pwd=SYSADM";
        List<Items> items = new List<Items>();
        List<Items> _items = new List<Items>();
        bool Orderby = false;
        public Form1()
        {
            InitializeComponent();
            dfW.Text = "0";
            dfH.Text = "0";
            // 字串列表
            List<string> stringList1 = new List<string> { "1", "3", "5", "7", "9" };
            // 字串列表
            List<string> stringList2 = new List<string> { "2", "4", "6", "8", "10" };
            AddList(stringList1, "ListBox1");
            AddList(stringList2, "ListBox2");

            this.Activated += new EventHandler(this.Form1_Activated);

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridView1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            //this.Deactivate += new EventHandler(this.Form1_Deactivate);
            // set so whole row is selected 讓整行被選取
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Query();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Query();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 前往頁面: https://tools.heho.com.tw/bmi/
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://tools.heho.com.tw/bmi/"
            };
            Process.Start(psi);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dfW.Text))
            {
                dfW.Text = "0";
            }
            if (string.IsNullOrEmpty(dfH.Text))
            {
                dfH.Text = "0";
            }
            if (dfH.Text != "0")
            {
                //bmival = 體重(kg) / 身高(m) ^ 2
                BMIVal.Text = "BMI計算結果 " + (double.Parse(dfW.Text) / Math.Pow(double.Parse(dfH.Text) / 100, 2)).ToString("0.00");
            }
            else
            {
                MessageBox.Show("身高不可為 0");
            }
        }

        public void AddList(List<string> source, string ListBoxName)
        {
            // 遍歷字串列表並將每個字串作為項目添加到 ListView
            foreach (string str in source)
            {
                if (ListBoxName == "ListBox1")
                {
                    ListBox1.Items.Add(str);
                }
                else
                {
                    ListBox2.Items.Add(str);
                }
            }
        }

        private void ToAction(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int selectedIndex = -1;
                switch (clickedButton.Name)
                {
                    case "btToL":
                        selectedIndex = ListBox2.SelectedIndex;
                        if (selectedIndex != -1)
                        {
                            ListBox1.Items.Add(ListBox2.Items[selectedIndex]);
                            ListBox2.Items.RemoveAt(selectedIndex);
                        }
                        break;
                    case "btToR":
                        selectedIndex = ListBox1.SelectedIndex;
                        if (selectedIndex != -1)
                        {
                            ListBox2.Items.Add(ListBox1.Items[selectedIndex]);
                            ListBox1.Items.RemoveAt(selectedIndex);
                        }
                        break;
                }
            }
        }


        public void Query()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = SqlStr;
            conn.Open();
            items = conn.Query<Items>("Select * From Items").ToList();
            dataGridView1.DataSource = items;
            _items = items; 
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Query();
            dataGridView1.DataSource = _items.Where(x => x.Name.Contains(textBoxSerch.Text) || x.Description.Contains(textBoxSerch.Text) || x.Type.Contains(textBoxSerch.Text) || x.LastUpdated.Contains(textBoxSerch.Text)).ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // 檢查有沒有選一行資料列
            if (isSelected == false)
            {
                MessageBox.Show("請選擇一筆資料");
                return;
            }
            string name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            // 跳訊息確定是否要刪除
            var result = MessageBox.Show(@"確定要刪除 '" + name + @"' 嗎?", "刪除", MessageBoxButtons.YesNo);
            // 如果選NO就結束
            if (result == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(SqlStr);
            conn.Execute("Delete From Items Where ID = @id", new { id });
            Query();
            MessageBox.Show("刪除成功");
            conn.Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            FormEdit formEdit = new FormEdit("New", item, SqlStr);
            formEdit.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // get the Employee data from row
            // 把員工資料抓出來
            Items item = new Items();
            if (isSelected)
            {
                item.ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                item.Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                item.Description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
                item.MarketValue = dataGridView1.SelectedRows[0].Cells["MarketValue"].Value.ToString();
                item.Quantity = dataGridView1.SelectedRows[0].Cells["Quantity"].Value.ToString();
                item.Type = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();
            }
            else
            {
                MessageBox.Show("請選擇一個員工");
                return;
            }
            FormEdit formUpdate = new FormEdit("Edit", item, SqlStr);
            formUpdate.ShowDialog();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName != null)
            {
                int index = e.ColumnIndex;

                if (index == 0 || index == 3 || index == 4)
                {
                    //轉成數字排序
                    _items = _items.OrderBy(x => double.Parse(x.GetType().GetProperty(columnName).GetValue(x, null).ToString())).ToList();
                }
                else
                {
                    _items = _items.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null).ToString()).ToList();
                }

                if (Orderby)
                {
                    _items.Reverse();
                }

                Orderby = !Orderby;

                dataGridView1.DataSource = _items;
            }
        }
    }
}
