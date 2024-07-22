using System.Diagnostics;

namespace JohnnyWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dfW.Text = "0";
            dfH.Text = "0";
            // �r��C��
            List<string> stringList1 = new List<string> { "1", "3", "5", "7", "9" };
            // �r��C��
            List<string> stringList2 = new List<string> { "2", "4", "6", "8", "10" };
            AddList(stringList1, "ListBox1");
            AddList(stringList2, "ListBox2");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // �e������: https://tools.heho.com.tw/bmi/
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
                //bmival = �魫(kg) / ����(m) ^ 2
                BMIVal.Text = "BMI�p�⵲�G " + (double.Parse(dfW.Text) / Math.Pow(double.Parse(dfH.Text) / 100, 2)).ToString("0.00");
            }
            else
            {
                MessageBox.Show("�������i�� 0");
            }
        }

        public void AddList(List<string> source, string ListBoxName)
        {
            bool result = true;

            // �M���r��C��ñN�C�Ӧr��@�����زK�[�� ListView
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
    }
}
