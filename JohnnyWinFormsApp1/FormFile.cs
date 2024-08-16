using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnnyWinFormsApp1
{
    public partial class FormFile : Form
    {
        List<Items> items = new List<Items>();
        public FormFile()
        {
            InitializeComponent();
            btOpenFile.Click += btOpenFile_Click;
            btExportFile.Click += btExportFile_Click;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridView1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
        }

        private void btExportFile_Click(object? sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();   
            var result = saveFileDialog.ShowDialog();
            List<string >lines = new List<string>();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show("Save file to " + saveFileDialog.FileName);
                string file = saveFileDialog.FileName;
                lines.Add("Name,Type,MarketValue,Quantity,Description");
                foreach (var item in items)
                {
                    //File.AppendAllText(file, $"{item.Name},{item.Type},{item.MarketValue},{item.Quantity},{item.Description}\n", Encoding.Default);
                    string line = $"{item.Name},{item.Type},{item.MarketValue},{item.Quantity},{item.Description}";
                    lines.Add(line);
                    File.WriteAllLines(file, lines,Encoding.ASCII);
                }

            }
        }

        private void btOpenFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                string[] fitems = File.ReadAllLines(file, Encoding.Default);
                //string[] items = File.ReadAllLines(file);
                listBoxFileData.Items.Clear();
                foreach (var item in fitems)
                {
                    listBoxFileData.Items.Add(item);
                }
                for (var i = 1; i < fitems.Length; i++)
                {
                    var data = fitems[i].Split(',');
                    Items item = new Items();
                    item.Name = data[0];
                    item.Type = data[1];
                    item.MarketValue = data[2];
                    item.Quantity = data[3];
                    item.Description = data[4];
                    items.Add(item);
                }
                dataGridView1.DataSource = items;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

        }
    }
}
