namespace toolsuiteapp.View
{
    partial class SoftwareInfoBaseForm
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
            components = new System.ComponentModel.Container();
            softwareImageBox = new PictureBox();
            logoLabel = new Label();
            softwareNameLabel = new Label();
            websiteLabel = new LinkLabel();
            softwareDescriptionLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            softwareDescriptionTextBox = new RichTextBox();
            label1 = new Label();
            softwareLastReviewedLabel = new Label();
            label2 = new Label();
            softwareLastDemoLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            vendorNameTextBox = new TextBox();
            vendorDateEstablishedTextBox = new TextBox();
            vendorEmployeeAmountTextBox = new TextBox();
            vendorWebsiteUrlTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            vendorContactNumbesTextBox = new RichTextBox();
            vendorLocationListTextBox = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            vendorUpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)softwareImageBox).BeginInit();
            SuspendLayout();
            // 
            // softwareImageBox
            // 
            softwareImageBox.Location = new Point(45, 49);
            softwareImageBox.Margin = new Padding(2);
            softwareImageBox.Name = "softwareImageBox";
            softwareImageBox.Size = new Size(177, 158);
            softwareImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            softwareImageBox.TabIndex = 0;
            softwareImageBox.TabStop = false;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Playbill", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logoLabel.Location = new Point(8, 5);
            logoLabel.Margin = new Padding(2, 0, 2, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(52, 19);
            logoLabel.TabIndex = 1;
            logoLabel.Text = "CITISOFT";
            // 
            // softwareNameLabel
            // 
            softwareNameLabel.AutoSize = true;
            softwareNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            softwareNameLabel.Location = new Point(257, 49);
            softwareNameLabel.Margin = new Padding(2, 0, 2, 0);
            softwareNameLabel.Name = "softwareNameLabel";
            softwareNameLabel.Size = new Size(0, 21);
            softwareNameLabel.TabIndex = 2;
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Enabled = false;
            websiteLabel.Location = new Point(250, 193);
            websiteLabel.Margin = new Padding(2, 0, 2, 0);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new Size(77, 15);
            websiteLabel.TabIndex = 4;
            websiteLabel.TabStop = true;
            websiteLabel.Text = "Visit Website ";
            websiteLabel.Visible = false;
            websiteLabel.LinkClicked += websiteLabel_LinkClicked;
            // 
            // softwareDescriptionLabel
            // 
            softwareDescriptionLabel.AutoSize = true;
            softwareDescriptionLabel.Location = new Point(45, 218);
            softwareDescriptionLabel.Margin = new Padding(2, 0, 2, 0);
            softwareDescriptionLabel.Name = "softwareDescriptionLabel";
            softwareDescriptionLabel.Size = new Size(70, 15);
            softwareDescriptionLabel.TabIndex = 7;
            softwareDescriptionLabel.Text = "Description:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // softwareDescriptionTextBox
            // 
            softwareDescriptionTextBox.Location = new Point(45, 236);
            softwareDescriptionTextBox.Name = "softwareDescriptionTextBox";
            softwareDescriptionTextBox.ReadOnly = true;
            softwareDescriptionTextBox.Size = new Size(282, 138);
            softwareDescriptionTextBox.TabIndex = 11;
            softwareDescriptionTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 377);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 12;
            label1.Text = "Last Reviewed:";
            // 
            // softwareLastReviewedLabel
            // 
            softwareLastReviewedLabel.AutoSize = true;
            softwareLastReviewedLabel.Location = new Point(135, 377);
            softwareLastReviewedLabel.Name = "softwareLastReviewedLabel";
            softwareLastReviewedLabel.Size = new Size(0, 15);
            softwareLastReviewedLabel.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 401);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 14;
            label2.Text = "Last Demo:";
            // 
            // softwareLastDemoLabel
            // 
            softwareLastDemoLabel.AutoSize = true;
            softwareLastDemoLabel.Location = new Point(117, 401);
            softwareLastDemoLabel.Name = "softwareLastDemoLabel";
            softwareLastDemoLabel.Size = new Size(0, 15);
            softwareLastDemoLabel.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(567, 39);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 16;
            label3.Text = "Vendor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 17;
            label4.Text = "Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 114);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 19;
            label5.Text = "Date Established:";
            // 
            // vendorNameTextBox
            // 
            vendorNameTextBox.Location = new Point(582, 79);
            vendorNameTextBox.Name = "vendorNameTextBox";
            vendorNameTextBox.Size = new Size(123, 23);
            vendorNameTextBox.TabIndex = 20;
            // 
            // vendorDateEstablishedTextBox
            // 
            vendorDateEstablishedTextBox.Location = new Point(582, 111);
            vendorDateEstablishedTextBox.Name = "vendorDateEstablishedTextBox";
            vendorDateEstablishedTextBox.Size = new Size(123, 23);
            vendorDateEstablishedTextBox.TabIndex = 21;
            // 
            // vendorEmployeeAmountTextBox
            // 
            vendorEmployeeAmountTextBox.Location = new Point(582, 140);
            vendorEmployeeAmountTextBox.Name = "vendorEmployeeAmountTextBox";
            vendorEmployeeAmountTextBox.Size = new Size(123, 23);
            vendorEmployeeAmountTextBox.TabIndex = 22;
            // 
            // vendorWebsiteUrlTextBox
            // 
            vendorWebsiteUrlTextBox.Location = new Point(582, 174);
            vendorWebsiteUrlTextBox.Name = "vendorWebsiteUrlTextBox";
            vendorWebsiteUrlTextBox.Size = new Size(123, 23);
            vendorWebsiteUrlTextBox.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 177);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 19;
            label6.Text = "Website Link:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 143);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 19;
            label7.Text = "Employee Amount:";
            // 
            // vendorContactNumbesTextBox
            // 
            vendorContactNumbesTextBox.Location = new Point(468, 244);
            vendorContactNumbesTextBox.Name = "vendorContactNumbesTextBox";
            vendorContactNumbesTextBox.Size = new Size(237, 96);
            vendorContactNumbesTextBox.TabIndex = 23;
            vendorContactNumbesTextBox.Text = "";
            // 
            // vendorLocationListTextBox
            // 
            vendorLocationListTextBox.Location = new Point(468, 367);
            vendorLocationListTextBox.Name = "vendorLocationListTextBox";
            vendorLocationListTextBox.Size = new Size(237, 96);
            vendorLocationListTextBox.TabIndex = 24;
            vendorLocationListTextBox.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(468, 226);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 25;
            label8.Text = "Contact Numbers:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(468, 349);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 26;
            label9.Text = "Location List:";
            // 
            // vendorUpdateButton
            // 
            vendorUpdateButton.Location = new Point(468, 486);
            vendorUpdateButton.Name = "vendorUpdateButton";
            vendorUpdateButton.Size = new Size(237, 23);
            vendorUpdateButton.TabIndex = 27;
            vendorUpdateButton.Text = "Update";
            vendorUpdateButton.UseVisualStyleBackColor = true;
            vendorUpdateButton.Click += vendorUpdateButton_Click;
            // 
            // SoftwareInfoBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 575);
            Controls.Add(vendorUpdateButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(vendorLocationListTextBox);
            Controls.Add(vendorContactNumbesTextBox);
            Controls.Add(vendorWebsiteUrlTextBox);
            Controls.Add(vendorEmployeeAmountTextBox);
            Controls.Add(vendorDateEstablishedTextBox);
            Controls.Add(vendorNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(softwareLastDemoLabel);
            Controls.Add(label2);
            Controls.Add(softwareLastReviewedLabel);
            Controls.Add(label1);
            Controls.Add(softwareDescriptionTextBox);
            Controls.Add(softwareDescriptionLabel);
            Controls.Add(websiteLabel);
            Controls.Add(softwareNameLabel);
            Controls.Add(logoLabel);
            Controls.Add(softwareImageBox);
            Margin = new Padding(2);
            Name = "SoftwareInfoBaseForm";
            ((System.ComponentModel.ISupportInitialize)softwareImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label logoLabel;
        public Label softwareNameLabel;
        public LinkLabel websiteLabel;
        public PictureBox softwareImageBox;
        public Label softwareDescriptionLabel;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox softwareDescriptionTextBox;
        private Label label1;
        private Label softwareLastReviewedLabel;
        private Label label2;
        private Label softwareLastDemoLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox vendorNameTextBox;
        private TextBox vendorDateEstablishedTextBox;
        private TextBox vendorEmployeeAmountTextBox;
        private TextBox vendorWebsiteUrlTextBox;
        private Label label6;
        private Label label7;
        private RichTextBox vendorContactNumbesTextBox;
        private RichTextBox vendorLocationListTextBox;
        private Label label8;
        private Label label9;
        private Button vendorUpdateButton;
    }
}