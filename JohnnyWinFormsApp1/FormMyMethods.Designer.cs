namespace JohnnyWinFormsApp1
{
    partial class FormMyMethods
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBoxMail = new TextBox();
            button7 = new Button();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(60, 53);
            button1.Name = "button1";
            button1.Size = new Size(84, 37);
            button1.TabIndex = 0;
            button1.Text = "手機";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 53);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 1;
            button2.Text = "筆記型電腦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(60, 106);
            button3.Name = "button3";
            button3.Size = new Size(84, 35);
            button3.TabIndex = 2;
            button3.Text = "會議";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 106);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 3;
            button4.Text = "生日";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(302, 106);
            button5.Name = "button5";
            button5.Size = new Size(96, 35);
            button5.TabIndex = 4;
            button5.Text = "LINQ Test";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(60, 165);
            button6.Name = "button6";
            button6.Size = new Size(92, 40);
            button6.TabIndex = 5;
            button6.Text = "產出資料夾";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(494, 59);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(301, 27);
            textBoxMail.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(302, 53);
            button7.Name = "button7";
            button7.Size = new Size(186, 37);
            button7.TabIndex = 7;
            button7.Text = "檢查是否為有效信箱=>";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(60, 224);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(1041, 465);
            treeView1.TabIndex = 8;
            // 
            // FormMyMethods
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 715);
            Controls.Add(treeView1);
            Controls.Add(button7);
            Controls.Add(textBoxMail);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMyMethods";
            Text = "FormMyMethods";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBoxMail;
        private Button button7;
        private TreeView treeView1;
    }
}