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
    public partial class FormMethods : Form
    {
        public FormMethods()
        {
            InitializeComponent();
        }

        private void FormMethods_Load(object sender, EventArgs e)
        {

        }

        public void PrintInClassMessage()
        {
            MessageBox.Show("In Class");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void PrintMessage()
            {
                MessageBox.Show("範圍內");
            }
            PrintMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintInClassMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintInClassMessage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintInClassMessage("Hello", true, MyEnum.Warning);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintInClassMessage(msg: "test", ShowTime: true, level: MyEnum.Info);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintInClassMessage("Hello Word");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToTaiwan();
            MessageBox.Show(s);
        }

        private void button8_Click(object sender, EventArgs e)
        { 
            var myNode = treeView1.Nodes.Add("Start");
            CreateTree(Environment.CurrentDirectory, myNode);
        }

        public void CreateTree(string dir,TreeNode curNote)
        {
            foreach (var directory in System.IO.Directory.GetDirectories(dir))
            {
                var node = curNote.Nodes.Add(directory);
                if (System.IO.Directory.GetDirectories(directory).Length > 0)
                {
                    CreateTree(directory, node);
                }
            }
        }




    }
}
