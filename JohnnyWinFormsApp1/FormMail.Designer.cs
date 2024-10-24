namespace JohnnyWinFormsApp1
{
    partial class FormMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBoxAddress = new TextBox();
            textBox2 = new TextBox();
            buttonSend = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(59, 55);
            label1.Name = "label1";
            label1.Size = new Size(105, 36);
            label1.TabIndex = 0;
            label1.Text = "收件者:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(59, 115);
            label2.Name = "label2";
            label2.Size = new Size(77, 36);
            label2.TabIndex = 2;
            label2.Text = "主旨:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(59, 250);
            label3.Name = "label3";
            label3.Size = new Size(71, 36);
            label3.TabIndex = 7;
            label3.Text = "內容";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(59, 181);
            label4.Name = "label4";
            label4.Size = new Size(71, 36);
            label4.TabIndex = 4;
            label4.Text = "附件";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(180, 250);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(695, 228);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(180, 174);
            button1.Name = "button1";
            button1.Size = new Size(103, 49);
            button1.TabIndex = 5;
            button1.Text = "檔案";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxAddress.Location = new Point(180, 57);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(695, 42);
            textBoxAddress.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox2.Location = new Point(180, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(695, 42);
            textBox2.TabIndex = 3;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonSend.Location = new Point(180, 513);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(113, 46);
            buttonSend.TabIndex = 9;
            buttonSend.Text = "送出";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(299, 186);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 6;
            label5.Text = "檔案名稱";
            // 
            // FormMail
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 720);
            Controls.Add(label5);
            Controls.Add(buttonSend);
            Controls.Add(textBox2);
            Controls.Add(textBoxAddress);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMail";
            Text = "FormMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBoxAddress;
        private TextBox textBox2;
        private Button buttonSend;
        private Label label5;
    }
}