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
            AddToWishlistLabel = new Button();
            websiteLabel = new LinkLabel();
            screenshotsPanel = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            screenPicBox1 = new PictureBox();
            softwareDescriptionLabel = new Label();
            softwareAdditionalInfoLabel = new Label();
            EditButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            softwareDescriptionTextBox = new RichTextBox();
            softwareAdditionalInfoTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)softwareImageBox).BeginInit();
            screenshotsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)screenPicBox1).BeginInit();
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
            softwareImageBox.Click += screenPicBox1_Click;
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
            // AddToWishlistLabel
            // 
            AddToWishlistLabel.Anchor = AnchorStyles.Right;
            AddToWishlistLabel.BackColor = SystemColors.ButtonHighlight;
            AddToWishlistLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddToWishlistLabel.Location = new Point(800, 23);
            AddToWishlistLabel.Margin = new Padding(2);
            AddToWishlistLabel.Name = "AddToWishlistLabel";
            AddToWishlistLabel.Size = new Size(86, 24);
            AddToWishlistLabel.TabIndex = 3;
            AddToWishlistLabel.Text = "Add to Wishlist ";
            AddToWishlistLabel.UseVisualStyleBackColor = false;
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
            // screenshotsPanel
            // 
            screenshotsPanel.Anchor = AnchorStyles.Right;
            screenshotsPanel.AutoScroll = true;
            screenshotsPanel.Controls.Add(pictureBox10);
            screenshotsPanel.Controls.Add(pictureBox9);
            screenshotsPanel.Controls.Add(pictureBox8);
            screenshotsPanel.Controls.Add(pictureBox7);
            screenshotsPanel.Controls.Add(pictureBox6);
            screenshotsPanel.Controls.Add(pictureBox5);
            screenshotsPanel.Controls.Add(pictureBox4);
            screenshotsPanel.Controls.Add(pictureBox3);
            screenshotsPanel.Controls.Add(screenPicBox1);
            screenshotsPanel.Location = new Point(8, 235);
            screenshotsPanel.Margin = new Padding(2);
            screenshotsPanel.Name = "screenshotsPanel";
            screenshotsPanel.Size = new Size(1036, 117);
            screenshotsPanel.TabIndex = 5;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(261, 13);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(105, 91);
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            pictureBox10.Click += screenPicBox1_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(878, 13);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(105, 91);
            pictureBox9.TabIndex = 7;
            pictureBox9.TabStop = false;
            pictureBox9.Click += screenPicBox1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(1006, 13);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(105, 91);
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            pictureBox8.Click += screenPicBox1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(778, 13);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 91);
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.Click += screenPicBox1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(659, 13);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(105, 91);
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += screenPicBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(529, 13);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(105, 91);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += screenPicBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(388, 13);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(124, 91);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += screenPicBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(86, 13);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 91);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += screenPicBox1_Click;
            // 
            // screenPicBox1
            // 
            screenPicBox1.Location = new Point(-58, 13);
            screenPicBox1.Margin = new Padding(2);
            screenPicBox1.Name = "screenPicBox1";
            screenPicBox1.Size = new Size(129, 91);
            screenPicBox1.TabIndex = 0;
            screenPicBox1.TabStop = false;
            screenPicBox1.Click += screenPicBox1_Click;
            // 
            // softwareDescriptionLabel
            // 
            softwareDescriptionLabel.AutoSize = true;
            softwareDescriptionLabel.Location = new Point(41, 385);
            softwareDescriptionLabel.Margin = new Padding(2, 0, 2, 0);
            softwareDescriptionLabel.Name = "softwareDescriptionLabel";
            softwareDescriptionLabel.Size = new Size(70, 15);
            softwareDescriptionLabel.TabIndex = 7;
            softwareDescriptionLabel.Text = "Description:";
            // 
            // softwareAdditionalInfoLabel
            // 
            softwareAdditionalInfoLabel.AutoSize = true;
            softwareAdditionalInfoLabel.Location = new Point(437, 385);
            softwareAdditionalInfoLabel.Margin = new Padding(2, 0, 2, 0);
            softwareAdditionalInfoLabel.Name = "softwareAdditionalInfoLabel";
            softwareAdditionalInfoLabel.Size = new Size(131, 15);
            softwareAdditionalInfoLabel.TabIndex = 8;
            softwareAdditionalInfoLabel.Text = "Additional Information:";
            softwareAdditionalInfoLabel.Visible = false;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(897, 23);
            EditButton.Margin = new Padding(2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(64, 24);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Visible = false;
            EditButton.Click += EditButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // softwareDescriptionTextBox
            // 
            softwareDescriptionTextBox.Location = new Point(45, 403);
            softwareDescriptionTextBox.Name = "softwareDescriptionTextBox";
            softwareDescriptionTextBox.ReadOnly = true;
            softwareDescriptionTextBox.Size = new Size(329, 138);
            softwareDescriptionTextBox.TabIndex = 11;
            softwareDescriptionTextBox.Text = "";
            // 
            // softwareAdditionalInfoTextBox
            // 
            softwareAdditionalInfoTextBox.Location = new Point(437, 403);
            softwareAdditionalInfoTextBox.Name = "softwareAdditionalInfoTextBox";
            softwareAdditionalInfoTextBox.ReadOnly = true;
            softwareAdditionalInfoTextBox.Size = new Size(358, 138);
            softwareAdditionalInfoTextBox.TabIndex = 12;
            softwareAdditionalInfoTextBox.Text = "";
            softwareAdditionalInfoTextBox.Visible = false;
            // 
            // SoftwareInfoBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 553);
            Controls.Add(softwareAdditionalInfoTextBox);
            Controls.Add(softwareDescriptionTextBox);
            Controls.Add(EditButton);
            Controls.Add(softwareAdditionalInfoLabel);
            Controls.Add(softwareDescriptionLabel);
            Controls.Add(screenshotsPanel);
            Controls.Add(websiteLabel);
            Controls.Add(AddToWishlistLabel);
            Controls.Add(softwareNameLabel);
            Controls.Add(logoLabel);
            Controls.Add(softwareImageBox);
            Margin = new Padding(2);
            Name = "SoftwareInfoBaseForm";
            ((System.ComponentModel.ISupportInitialize)softwareImageBox).EndInit();
            screenshotsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)screenPicBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label logoLabel;
        private Panel screenshotsPanel;
        public Label softwareNameLabel;
        public Button AddToWishlistLabel;
        public LinkLabel websiteLabel;
        public PictureBox softwareImageBox;
        public Label softwareDescriptionLabel;
        public Label softwareAdditionalInfoLabel;
        public Button EditButton;
        public PictureBox pictureBox3;
        public PictureBox screenPicBox1;
        public PictureBox pictureBox10;
        public PictureBox pictureBox9;
        public PictureBox pictureBox8;
        public PictureBox pictureBox7;
        public PictureBox pictureBox6;
        public PictureBox pictureBox5;
        public PictureBox pictureBox4;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox softwareDescriptionTextBox;
        private RichTextBox softwareAdditionalInfoTextBox;
    }
}