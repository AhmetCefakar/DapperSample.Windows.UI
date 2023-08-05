namespace DapperSample.Windows.UI.Forms
{
    partial class InsertProductForm
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
            TextBoxPrice = new TextBox();
            TextBoxModleYear = new TextBox();
            TextBoxProductName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ButtonProductInsert = new Button();
            ComboBoxCatalog = new ComboBox();
            label2 = new Label();
            ComboBoxBrand = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.Location = new Point(126, 156);
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.Size = new Size(308, 27);
            TextBoxPrice.TabIndex = 23;
            // 
            // TextBoxModleYear
            // 
            TextBoxModleYear.Location = new Point(126, 117);
            TextBoxModleYear.Name = "TextBoxModleYear";
            TextBoxModleYear.Size = new Size(308, 27);
            TextBoxModleYear.TabIndex = 22;
            // 
            // TextBoxProductName
            // 
            TextBoxProductName.Location = new Point(126, 80);
            TextBoxProductName.Name = "TextBoxProductName";
            TextBoxProductName.Size = new Size(308, 27);
            TextBoxProductName.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 156);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 20;
            label5.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 117);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 19;
            label4.Text = "Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 83);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 18;
            label3.Text = "Product :";
            // 
            // ButtonProductInsert
            // 
            ButtonProductInsert.Location = new Point(13, 189);
            ButtonProductInsert.Name = "ButtonProductInsert";
            ButtonProductInsert.Size = new Size(421, 29);
            ButtonProductInsert.TabIndex = 16;
            ButtonProductInsert.Text = "Insert";
            ButtonProductInsert.UseVisualStyleBackColor = true;
            ButtonProductInsert.Click += ButtonProductInsert_Click;
            // 
            // ComboBoxCatalog
            // 
            ComboBoxCatalog.FormattingEnabled = true;
            ComboBoxCatalog.Location = new Point(126, 46);
            ComboBoxCatalog.Name = "ComboBoxCatalog";
            ComboBoxCatalog.Size = new Size(308, 28);
            ComboBoxCatalog.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 49);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 14;
            label2.Text = "Catalog :";
            // 
            // ComboBoxBrand
            // 
            ComboBoxBrand.FormattingEnabled = true;
            ComboBoxBrand.Location = new Point(126, 12);
            ComboBoxBrand.Name = "ComboBoxBrand";
            ComboBoxBrand.Size = new Size(308, 28);
            ComboBoxBrand.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 12;
            label1.Text = "Brand :";
            // 
            // InsertProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 253);
            Controls.Add(TextBoxPrice);
            Controls.Add(TextBoxModleYear);
            Controls.Add(TextBoxProductName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ButtonProductInsert);
            Controls.Add(ComboBoxCatalog);
            Controls.Add(label2);
            Controls.Add(ComboBoxBrand);
            Controls.Add(label1);
            Name = "InsertProductForm";
            Text = "Insert Product";
            Load += InsertProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxPrice;
        private TextBox TextBoxModleYear;
        private TextBox TextBoxProductName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button ButtonProductInsert;
        private ComboBox ComboBoxCatalog;
        private Label label2;
        private ComboBox ComboBoxBrand;
        private Label label1;
    }
}