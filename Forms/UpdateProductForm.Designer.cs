namespace DapperSample.Windows.UI.Forms
{
    partial class UpdateProductForm
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
            ComboBoxBrand = new ComboBox();
            ComboBoxCatalog = new ComboBox();
            label2 = new Label();
            ButtonProductUpdate = new Button();
            ButtonProductDelete = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TextBoxProductName = new TextBox();
            TextBoxModleYear = new TextBox();
            TextBoxPrice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Brand :";
            // 
            // ComboBoxBrand
            // 
            ComboBoxBrand.FormattingEnabled = true;
            ComboBoxBrand.Location = new Point(145, 36);
            ComboBoxBrand.Name = "ComboBoxBrand";
            ComboBoxBrand.Size = new Size(308, 28);
            ComboBoxBrand.TabIndex = 1;
            // 
            // ComboBoxCatalog
            // 
            ComboBoxCatalog.FormattingEnabled = true;
            ComboBoxCatalog.Location = new Point(145, 70);
            ComboBoxCatalog.Name = "ComboBoxCatalog";
            ComboBoxCatalog.Size = new Size(308, 28);
            ComboBoxCatalog.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Catalog :";
            // 
            // ButtonProductUpdate
            // 
            ButtonProductUpdate.Location = new Point(32, 213);
            ButtonProductUpdate.Name = "ButtonProductUpdate";
            ButtonProductUpdate.Size = new Size(206, 29);
            ButtonProductUpdate.TabIndex = 4;
            ButtonProductUpdate.Text = "Update";
            ButtonProductUpdate.UseVisualStyleBackColor = true;
            ButtonProductUpdate.Click += ButtonProductUpdate_Click;
            // 
            // ButtonProductDelete
            // 
            ButtonProductDelete.Location = new Point(244, 213);
            ButtonProductDelete.Name = "ButtonProductDelete";
            ButtonProductDelete.Size = new Size(209, 29);
            ButtonProductDelete.TabIndex = 5;
            ButtonProductDelete.Text = "Delete";
            ButtonProductDelete.UseVisualStyleBackColor = true;
            ButtonProductDelete.Click += ButtonProductDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 107);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Product :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 141);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 7;
            label4.Text = "Model :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 180);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 8;
            label5.Text = "Price :";
            // 
            // TextBoxProductName
            // 
            TextBoxProductName.Location = new Point(145, 104);
            TextBoxProductName.Name = "TextBoxProductName";
            TextBoxProductName.Size = new Size(308, 27);
            TextBoxProductName.TabIndex = 9;
            // 
            // TextBoxModleYear
            // 
            TextBoxModleYear.Location = new Point(145, 141);
            TextBoxModleYear.Name = "TextBoxModleYear";
            TextBoxModleYear.Size = new Size(308, 27);
            TextBoxModleYear.TabIndex = 10;
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.Location = new Point(145, 180);
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.Size = new Size(308, 27);
            TextBoxPrice.TabIndex = 11;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 308);
            Controls.Add(TextBoxPrice);
            Controls.Add(TextBoxModleYear);
            Controls.Add(TextBoxProductName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ButtonProductDelete);
            Controls.Add(ButtonProductUpdate);
            Controls.Add(ComboBoxCatalog);
            Controls.Add(label2);
            Controls.Add(ComboBoxBrand);
            Controls.Add(label1);
            Name = "UpdateProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Update";
            Load += UpdateProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ComboBoxBrand;
        private ComboBox ComboBoxCatalog;
        private Label label2;
        private Button ButtonProductUpdate;
        private Button ButtonProductDelete;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextBoxProductName;
        private TextBox TextBoxModleYear;
        private TextBox TextBoxPrice;
    }
}