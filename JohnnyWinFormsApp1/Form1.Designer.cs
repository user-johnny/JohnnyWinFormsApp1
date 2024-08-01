namespace JohnnyWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BMIVal = new Label();
            dfW = new TextBox();
            dfH = new TextBox();
            Start = new Button();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            tabPage2 = new TabPage();
            ListBox2 = new ListBox();
            ListBox1 = new ListBox();
            btToL = new Button();
            btToR = new Button();
            tabPage3 = new TabPage();
            buttonEdit = new Button();
            buttonNew = new Button();
            buttonDel = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1099, 592);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BMIVal);
            tabPage1.Controls.Add(dfW);
            tabPage1.Controls.Add(dfH);
            tabPage1.Controls.Add(Start);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1091, 560);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "BMI計算";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BMIVal
            // 
            BMIVal.AutoSize = true;
            BMIVal.Font = new Font("Microsoft JhengHei UI", 12F);
            BMIVal.Location = new Point(35, 284);
            BMIVal.Name = "BMIVal";
            BMIVal.Size = new Size(129, 25);
            BMIVal.TabIndex = 7;
            BMIVal.Text = "BMI計算結果";
            // 
            // dfW
            // 
            dfW.Location = new Point(161, 144);
            dfW.Name = "dfW";
            dfW.Size = new Size(85, 27);
            dfW.TabIndex = 6;
            dfW.TextAlign = HorizontalAlignment.Right;
            // 
            // dfH
            // 
            dfH.Location = new Point(161, 100);
            dfH.Name = "dfH";
            dfH.Size = new Size(85, 27);
            dfH.TabIndex = 5;
            dfH.TextAlign = HorizontalAlignment.Right;
            // 
            // Start
            // 
            Start.BackColor = Color.Yellow;
            Start.Font = new Font("Microsoft JhengHei UI", 12F);
            Start.Location = new Point(151, 204);
            Start.Name = "Start";
            Start.Size = new Size(108, 46);
            Start.TabIndex = 4;
            Start.Text = "計算";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F);
            label3.Location = new Point(35, 146);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "體重(公斤)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F);
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "身高(公分)";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft JhengHei UI", 12F);
            linkLabel1.Location = new Point(101, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "BMI";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "BMI";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ListBox2);
            tabPage2.Controls.Add(ListBox1);
            tabPage2.Controls.Add(btToL);
            tabPage2.Controls.Add(btToR);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1091, 560);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "陣列";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBox2
            // 
            ListBox2.FormattingEnabled = true;
            ListBox2.ItemHeight = 19;
            ListBox2.Location = new Point(335, 85);
            ListBox2.Name = "ListBox2";
            ListBox2.Size = new Size(169, 213);
            ListBox2.TabIndex = 5;
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 19;
            ListBox1.Location = new Point(49, 85);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(169, 213);
            ListBox1.TabIndex = 4;
            // 
            // btToL
            // 
            btToL.Font = new Font("Microsoft JhengHei UI", 12F);
            btToL.Location = new Point(253, 222);
            btToL.Name = "btToL";
            btToL.Size = new Size(50, 50);
            btToL.TabIndex = 3;
            btToL.Text = "<=";
            btToL.UseVisualStyleBackColor = true;
            btToL.Click += ToAction;
            // 
            // btToR
            // 
            btToR.Font = new Font("Microsoft JhengHei UI", 12F);
            btToR.Location = new Point(253, 115);
            btToR.Name = "btToR";
            btToR.Size = new Size(50, 50);
            btToR.TabIndex = 2;
            btToR.Text = "=>";
            btToR.UseVisualStyleBackColor = true;
            btToR.Click += ToAction;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonEdit);
            tabPage3.Controls.Add(buttonNew);
            tabPage3.Controls.Add(buttonDel);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1091, 560);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sql";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(234, 38);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "編輯";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(34, 38);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(94, 29);
            buttonNew.TabIndex = 12;
            buttonNew.Text = "新增";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(134, 38);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(94, 29);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "刪除";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(334, 38);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "查詢";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1044, 314);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 599);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button Start;
        private Label label3;
        private Label label2;
        private TextBox dfW;
        private TextBox dfH;
        private Label BMIVal;
        private Button btToL;
        private Button btToR;
        private ListBox ListBox2;
        private ListBox ListBox1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button buttonDel;
        private Button buttonNew;
        private Button buttonEdit;
    }
}
