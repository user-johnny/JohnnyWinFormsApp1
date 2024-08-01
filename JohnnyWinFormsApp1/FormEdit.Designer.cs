namespace JohnnyWinFormsApp1
{
    partial class FormEdit
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
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxMarketValue = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxType = new TextBox();
            textBoxID = new TextBox();
            buttonSave = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F);
            label1.Location = new Point(37, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "物品名稱";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F);
            label2.Location = new Point(37, 124);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 1;
            label2.Text = "物品描述";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F);
            label3.Location = new Point(36, 313);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 2;
            label3.Text = "價值";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F);
            label4.Location = new Point(363, 313);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 3;
            label4.Text = "數量";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F);
            label5.Location = new Point(37, 213);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 30);
            label5.TabIndex = 4;
            label5.Text = "物品種類";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(199, 36);
            textBoxName.MaxLength = 100;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(397, 37);
            textBoxName.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(197, 117);
            textBoxDescription.MaxLength = 1000;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(399, 37);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxMarketValue
            // 
            textBoxMarketValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMarketValue.Location = new Point(144, 306);
            textBoxMarketValue.MaxLength = 5;
            textBoxMarketValue.Name = "textBoxMarketValue";
            textBoxMarketValue.Size = new Size(102, 37);
            textBoxMarketValue.TabIndex = 7;
            textBoxMarketValue.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(494, 306);
            textBoxQuantity.MaxLength = 3;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(102, 37);
            textBoxQuantity.TabIndex = 8;
            textBoxQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(199, 213);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(398, 37);
            textBoxType.TabIndex = 9;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(602, 45);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 37);
            textBoxID.TabIndex = 10;
            textBoxID.Visible = false;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(173, 418);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 43);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "存檔";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(363, 418);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(105, 43);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "離開";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 493);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(textBoxID);
            Controls.Add(textBoxType);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxMarketValue);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            Margin = new Padding(5);
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxMarketValue;
        private TextBox textBoxQuantity;
        private TextBox textBoxType;
        private TextBox textBoxID;
        private Button buttonSave;
        private Button buttonExit;
    }
}