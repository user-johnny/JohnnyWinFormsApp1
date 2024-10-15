namespace JohnnyWinFormsApp1
{
    partial class FormMethods
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(50, 57);
            label1.Name = "label1";
            label1.Size = new Size(183, 36);
            label1.TabIndex = 0;
            label1.Text = "方法定義位置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(50, 135);
            label2.Name = "label2";
            label2.Size = new Size(71, 36);
            label2.TabIndex = 1;
            label2.Text = "參數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(50, 212);
            label3.Name = "label3";
            label3.Size = new Size(127, 36);
            label3.TabIndex = 2;
            label3.Text = "擴充方法";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(50, 294);
            label4.Name = "label4";
            label4.Size = new Size(127, 36);
            label4.TabIndex = 3;
            label4.Text = "遞迴方法";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(310, 46);
            button1.Name = "button1";
            button1.Size = new Size(218, 56);
            button1.TabIndex = 4;
            button1.Text = "在範圍內";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(565, 46);
            button2.Name = "button2";
            button2.Size = new Size(214, 56);
            button2.TabIndex = 5;
            button2.Text = "在Class內";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(829, 44);
            button3.Name = "button3";
            button3.Size = new Size(179, 58);
            button3.TabIndex = 6;
            button3.Text = "在新類別中";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button4.Location = new Point(310, 128);
            button4.Name = "button4";
            button4.Size = new Size(218, 52);
            button4.TabIndex = 7;
            button4.Text = "三個參數";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button5.Location = new Point(565, 128);
            button5.Name = "button5";
            button5.Size = new Size(214, 52);
            button5.TabIndex = 8;
            button5.Text = "選擇性參數";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button6.Location = new Point(829, 128);
            button6.Name = "button6";
            button6.Size = new Size(179, 52);
            button6.TabIndex = 9;
            button6.Text = "具名參數";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button7.Location = new Point(310, 203);
            button7.Name = "button7";
            button7.Size = new Size(218, 54);
            button7.TabIndex = 10;
            button7.Text = "時間擴充";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button8.Location = new Point(310, 284);
            button8.Name = "button8";
            button8.Size = new Size(218, 46);
            button8.TabIndex = 11;
            button8.Text = "產出資料夾結構";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(310, 350);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(698, 366);
            treeView1.TabIndex = 12;
            // 
            // FormMethods
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 728);
            Controls.Add(treeView1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMethods";
            Text = "FormMethods";
            WindowState = FormWindowState.Maximized;
            Load += FormMethods_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TreeView treeView1;
    }
}