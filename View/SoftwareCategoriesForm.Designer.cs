namespace toolsuiteapp.View
{
    partial class SoftwareCategoriesForm
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
            dataGridViewSoftwareCategories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSoftwareCategories).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSoftwareCategories
            // 
            dataGridViewSoftwareCategories.AllowUserToOrderColumns = true;
            dataGridViewSoftwareCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSoftwareCategories.Location = new Point(139, 115);
            dataGridViewSoftwareCategories.Name = "dataGridViewSoftwareCategories";
            dataGridViewSoftwareCategories.RowHeadersWidth = 62;
            dataGridViewSoftwareCategories.RowTemplate.Height = 33;
            dataGridViewSoftwareCategories.Size = new Size(552, 640);
            dataGridViewSoftwareCategories.TabIndex = 0;
            // 
            // SoftwareCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 1413);
            Controls.Add(dataGridViewSoftwareCategories);
            Name = "SoftwareCategoriesForm";
            Text = "SoftwareCategoriesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSoftwareCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSoftwareCategories;
    }
}