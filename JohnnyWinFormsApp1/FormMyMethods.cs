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
    public partial class FormMyMethods : Form
    {
        public void GetAllFilePaths(string dir, TreeNode curNote)
        {
            foreach (var directory in System.IO.Directory.GetDirectories(dir))
            {
                var node = curNote.Nodes.Add(directory);
                if (System.IO.Directory.GetDirectories(directory).Length > 0)
                {
                    GetAllFilePaths(directory, node);
                }
            }
        }

        public FormMyMethods()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMethod myMethod = new MyMethod();
            myMethod.AddToCart("手機", isAddCoupon: true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyMethod myMethod = new MyMethod();
            myMethod.AddToCart("筆記型電腦", 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool isValid = textBoxMail.Text.IsValidEmail();
            if (isValid)
            {
                MessageBox.Show("電子郵件格式正確");
            }
            else
            {
                MessageBox.Show("電子郵件格式錯誤");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyMethod myMethod = new MyMethod();
            string eventInfo = myMethod.AddEvent("會議", new DateTime(2024, 12, 31, hour: 14, minute: 30, second: 0));
            MessageBox.Show(eventInfo);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyMethod myMethod = new MyMethod();
            string eventInfo = myMethod.AddEvent("生日", new DateTime(2024, 9, 18), true);
            MessageBox.Show(eventInfo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyMethod myMethod = new MyMethod();
            string[] cleaned = myMethod.CleanProducts(["筆電", "筆 電", "手機  ", "平板", "手 機", "耳機", ""]);
            MessageBox.Show(string.Join(",", cleaned));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myNode = treeView1.Nodes.Add("Start");
            GetAllFilePaths(Environment.CurrentDirectory, myNode);
        }
    }
}
