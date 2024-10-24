namespace JohnnyWinFormsApp1
{
    partial class FormTaiwanCalendar
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
            textBoxUrl = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(59, 71);
            button1.Name = "button1";
            button1.Size = new Size(204, 61);
            button1.TabIndex = 0;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(59, 18);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(651, 27);
            textBoxUrl.TabIndex = 1;
            // 
            // FormTaiwanCalendar
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxUrl);
            Controls.Add(button1);
            Name = "FormTaiwanCalendar";
            Text = "FormTaiwanCalendar";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxUrl;
    }
}