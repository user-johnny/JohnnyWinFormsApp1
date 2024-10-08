﻿namespace JohnnyWinFormsApp1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage3 = new TabPage();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage4 = new TabPage();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            buttonPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
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
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 455);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(23, 306);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 493);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cartesianChart1);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 461);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "折線圖";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Dock = DockStyle.Fill;
            cartesianChart1.Location = new Point(3, 3);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(833, 455);
            cartesianChart1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartesianChart2);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(839, 461);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "直線圖";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Dock = DockStyle.Fill;
            cartesianChart2.Location = new Point(0, 0);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(839, 461);
            cartesianChart2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(pieChart1);
            tabPage4.Location = new Point(4, 28);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(839, 461);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "圓餅圖";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pieChart1
            // 
            pieChart1.Dock = DockStyle.Fill;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(0, 0);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(839, 461);
            pieChart1.TabIndex = 0;
            pieChart1.Total = null;
            // 
            // buttonPDF
            // 
            buttonPDF.Font = new Font("Microsoft JhengHei UI", 16F);
            buttonPDF.Location = new Point(322, 64);
            buttonPDF.Name = "buttonPDF";
            buttonPDF.Size = new Size(105, 41);
            buttonPDF.TabIndex = 6;
            buttonPDF.Text = "PDF";
            buttonPDF.UseVisualStyleBackColor = true;
            buttonPDF.Click += buttonPDF_Click;
            // 
            // FormInternet
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 861);
            Controls.Add(buttonPDF);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBoxURL);
            Controls.Add(btDownload);
            Name = "FormInternet";
            Text = "FormInternet";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDownload;
        private TextBox textBoxURL;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private TabPage tabPage3;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private TabPage tabPage4;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Button buttonPDF;
    }
}