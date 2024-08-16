namespace JohnnyWinFormsApp1
{
    partial class FormFile
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btExportFile = new Button();
            btOpenFile = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBoxFileData = new ListBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1167, 846);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btExportFile);
            panel1.Controls.Add(btOpenFile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 94);
            panel1.TabIndex = 0;
            // 
            // btExportFile
            // 
            btExportFile.Font = new Font("Microsoft JhengHei UI", 16F);
            btExportFile.Location = new Point(164, 18);
            btExportFile.Name = "btExportFile";
            btExportFile.Size = new Size(162, 63);
            btExportFile.TabIndex = 1;
            btExportFile.Text = "產出";
            btExportFile.UseVisualStyleBackColor = true;
            // 
            // btOpenFile
            // 
            btOpenFile.Font = new Font("Microsoft JhengHei UI", 16F);
            btOpenFile.Location = new Point(9, 18);
            btOpenFile.Name = "btOpenFile";
            btOpenFile.Size = new Size(144, 63);
            btOpenFile.TabIndex = 0;
            btOpenFile.Text = "讀取";
            btOpenFile.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Microsoft JhengHei UI", 16F);
            tabControl1.Location = new Point(3, 103);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1161, 740);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxFileData);
            tabPage1.Font = new Font("Microsoft JhengHei UI", 16F);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1153, 692);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "原始內容";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxFileData
            // 
            listBoxFileData.Dock = DockStyle.Fill;
            listBoxFileData.FormattingEnabled = true;
            listBoxFileData.ItemHeight = 35;
            listBoxFileData.Location = new Point(3, 3);
            listBoxFileData.Name = "listBoxFileData";
            listBoxFileData.Size = new Size(1147, 686);
            listBoxFileData.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Font = new Font("Microsoft JhengHei UI", 16F);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1153, 692);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "表格顯示";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1147, 686);
            dataGridView1.TabIndex = 0;
            // 
            // FormFile
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 846);
            Controls.Add(tableLayoutPanel1);
            Name = "FormFile";
            Text = "FormFile";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btExportFile;
        private Button btOpenFile;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBoxFileData;
        private DataGridView dataGridView1;
    }
}