namespace DapperSample.Windows.UI
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            DataGridProductDataSource = new DataGridView();
            ButtonProductInsert = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridProductDataSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataGridProductDataSource);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // DataGridProductDataSource
            // 
            DataGridProductDataSource.AllowUserToAddRows = false;
            DataGridProductDataSource.AllowUserToDeleteRows = false;
            DataGridProductDataSource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridProductDataSource.Dock = DockStyle.Fill;
            DataGridProductDataSource.Location = new Point(3, 23);
            DataGridProductDataSource.Name = "DataGridProductDataSource";
            DataGridProductDataSource.ReadOnly = true;
            DataGridProductDataSource.RowHeadersWidth = 51;
            DataGridProductDataSource.RowTemplate.Height = 29;
            DataGridProductDataSource.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridProductDataSource.Size = new Size(850, 607);
            DataGridProductDataSource.TabIndex = 0;
            DataGridProductDataSource.CellDoubleClick += DataGridProductDataSource_CellDoubleClick;
            // 
            // ButtonProductInsert
            // 
            ButtonProductInsert.Location = new Point(15, 651);
            ButtonProductInsert.Name = "ButtonProductInsert";
            ButtonProductInsert.Size = new Size(853, 29);
            ButtonProductInsert.TabIndex = 1;
            ButtonProductInsert.Text = "Add Product";
            ButtonProductInsert.UseVisualStyleBackColor = true;
            ButtonProductInsert.Click += ButtonProductInsert_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 687);
            Controls.Add(ButtonProductInsert);
            Controls.Add(groupBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridProductDataSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DataGridProductDataSource;
        private Button ButtonProductInsert;
    }
}