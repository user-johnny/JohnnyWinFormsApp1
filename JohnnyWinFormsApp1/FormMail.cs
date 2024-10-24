using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MimeKit;

namespace JohnnyWinFormsApp1
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.Subject = textBox2.Text;
                message.From.Add(new MailboxAddress("abcd@abcd.com", "abcd@abcd.com"));
                message.To.Add(new MailboxAddress(textBoxAddress.Text, textBoxAddress.Text));
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = richTextBox1.Text;
                if (label5.Text != "檔案名稱")
                {
                    bodyBuilder.Attachments.Add(label5.Text);
                }
                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.hibox.biz", 587, false);
                    client.Authenticate("abcd@abcd.com", "password");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                File.AppendAllText("error.log", ex.Message);
            }
            finally
            {
                MessageBox.Show("Mail sent");
                File.AppendAllText("mail.log", "執行成功"+DateTime.Now);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            bool result = dialog.ShowDialog() == DialogResult.OK;
            if (result)
            {
                label5.Text   = dialog.FileName;
            }
        }
    }
}
