namespace JohnnyWinFormsApp1
{
    partial class FormInternet
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
            btDownload = new Button();
            textBoxURL = new TextBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btDownload
            // 
            btDownload.Font = new Font("Microsoft JhengHei UI", 16F);
            btDownload.Location = new Point(14, 64);
            btDownload.Name = "btDownload";
            btDownload.Size = new Size(132, 41);
            btDownload.TabIndex = 0;
            btDownload.Text = "下載";
            btDownload.UseVisualStyleBackColor = true;
            btDownload.Click += btDownload_Click;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(14, 18);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(758, 27);
            textBoxURL.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(23, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(847, 175);
            listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(843, 411);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16F);
            button1.Location = new Point(167, 64);
            button1.Name = "button1";
            button1.Size = new Size(139, 41);
            button1.TabIndex = 4;
            button1.Text = "To Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormInternet
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 763);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(textBoxURL);
            Controls.Add(btDownload);
            Name = "FormInternet";
            Text = "FormInternet";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDownload;
        private TextBox textBoxURL;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}