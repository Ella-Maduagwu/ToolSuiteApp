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
            logoLabel = new Label();
            addButton = new Button();
            categoriesLabel = new Label();
            wealthManagLabel = new Label();
            assetManagementLabel = new Label();
            investmentLabel = new Label();
            dataManageLabel = new Label();
            SuspendLayout();
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new Point(7, 4);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(59, 25);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "label1";
            // 
            // addButton
            // 
            addButton.Location = new Point(1488, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(133, 57);
            addButton.TabIndex = 1;
            addButton.Text = "Add   +";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            categoriesLabel.Location = new Point(136, 85);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(135, 32);
            categoriesLabel.TabIndex = 2;
            categoriesLabel.Text = "Categories";
            // 
            // wealthManagLabel
            // 
            wealthManagLabel.AutoSize = true;
            wealthManagLabel.Location = new Point(155, 193);
            wealthManagLabel.Name = "wealthManagLabel";
            wealthManagLabel.Size = new Size(181, 25);
            wealthManagLabel.TabIndex = 3;
            wealthManagLabel.Text = "Wealth Management ";
            wealthManagLabel.Click += wealthManagLabel_Click;
            // 
            // assetManagementLabel
            // 
            assetManagementLabel.AutoSize = true;
            assetManagementLabel.Location = new Point(155, 288);
            assetManagementLabel.Name = "assetManagementLabel";
            assetManagementLabel.Size = new Size(170, 25);
            assetManagementLabel.TabIndex = 4;
            assetManagementLabel.Text = "Asset Management ";
            // 
            // investmentLabel
            // 
            investmentLabel.AutoSize = true;
            investmentLabel.Location = new Point(155, 389);
            investmentLabel.Name = "investmentLabel";
            investmentLabel.Size = new Size(168, 25);
            investmentLabel.TabIndex = 5;
            investmentLabel.Text = "Investment Banking";
            // 
            // dataManageLabel
            // 
            dataManageLabel.AutoSize = true;
            dataManageLabel.Location = new Point(155, 492);
            dataManageLabel.Name = "dataManageLabel";
            dataManageLabel.Size = new Size(167, 25);
            dataManageLabel.TabIndex = 6;
            dataManageLabel.Text = "Data MAnagement ";
            // 
            // SoftwareCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 1367);
            Controls.Add(dataManageLabel);
            Controls.Add(investmentLabel);
            Controls.Add(assetManagementLabel);
            Controls.Add(wealthManagLabel);
            Controls.Add(categoriesLabel);
            Controls.Add(addButton);
            Controls.Add(logoLabel);
            Name = "SoftwareCategoriesForm";
            Text = "SoftwareCategoriesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logoLabel;
        private Button addButton;
        private Label categoriesLabel;
        private Label wealthManagLabel;
        private Label assetManagementLabel;
        private Label investmentLabel;
        private Label dataManageLabel;
    }
}