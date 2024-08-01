using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Dapper;
using System.Diagnostics;

namespace JohnnyWinFormsApp1
{
    public partial class FormEdit : Form
    {
        private string SqlStr_ = "";
        private Items Item_;
        private string EditType_ = "";
        public FormEdit(string EditType,Items item ,string SqlStr)
        {
            InitializeComponent();
            this.SqlStr_ = SqlStr;
            this.Item_ = item;
            this.EditType_ = EditType;
            // 設置 KeyPress 事件處理程序
            textBoxMarketValue.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBoxQuantity.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBoxMarketValue.Text = "0";
            textBoxQuantity.Text = "0";
            if(EditType_ == "Edit")
            {
                ShowItem();
            }
        }

        public void ShowItem()
        {
            textBoxID.Text = Item_.ID;
            textBoxName.Text = Item_.Name;
            textBoxDescription.Text = Item_.Description;
            textBoxMarketValue.Text = Item_.MarketValue;
            textBoxQuantity.Text = Item_.Quantity;
            textBoxType.Text = Item_.Type;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 檢查輸入字符是否是數字或控制字符（如退格鍵）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 阻止非數字字符的輸入
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 系統日期轉string 
            string LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string Name = textBoxName.Text.Length <= 100 ? textBoxName.Text : textBoxName.Text.Substring(0, 100);    
            if(Name == "")
            {
                MessageBox.Show("物品名稱不可為空");
                return;
            }
            //get textBoxMarketValue.Text 轉成 int  
            int MarketValueInt = int.Parse(textBoxMarketValue.Text);
            if(MarketValueInt > 10000)
            {
                MessageBox.Show("價值不可超過10000");
                return;
            }

            string Description = textBoxDescription.Text.Length <= 1000 ? textBoxDescription.Text : textBoxDescription.Text.Substring(0, 1000);  
            string MarketValue = textBoxMarketValue.Text;
            string Quantity = textBoxQuantity.Text;
            string Type = textBoxType.Text;
            string ID = textBoxID.Text;
            // 存檔
            SqlConnection conn = new SqlConnection(SqlStr_);
            conn.Open();
            string Sqlstr = "";
            if (EditType_ == "New")
            {
                Sqlstr = @"Insert into Items(Name,Description,MarketValue,Quantity,Type,LastUpdated)
                               Values(@Name,@Description,@MarketValue,@Quantity,@Type,@LastUpdated)";
            }
            else
            {
                Sqlstr = @"Update Items Set Name = @Name, Description = @Description , MarketValue = @MarketValue , Quantity = @Quantity , Type = @Type  , LastUpdated = @LastUpdated
                    Where ID = @ID";
            }
            conn.Execute(Sqlstr,
                new { Name, Description, MarketValue, Quantity, Type, ID, LastUpdated }
                );
            conn.Close();
            MessageBox.Show("存檔成功");
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
