namespace toolsuiteapp.View
{
    partial class HomepageForm
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
            searchTxtBox = new TextBox();
            logoLabel = new Label();
            profileButton = new Button();
            softwareButton = new Button();
            vendorButton = new Button();
            NotificationButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            softwareContainerLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // searchTxtBox
            // 
            searchTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchTxtBox.Location = new Point(306, 11);
            searchTxtBox.Margin = new Padding(2);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Search";
            searchTxtBox.Size = new Size(514, 23);
            searchTxtBox.TabIndex = 0;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Playbill", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logoLabel.Location = new Point(2, 16);
            logoLabel.Margin = new Padding(2, 0, 2, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(60, 19);
            logoLabel.TabIndex = 3;
            logoLabel.Text = "CITISOFT";
            // 
            // profileButton
            // 
            profileButton.Location = new Point(1, 64);
            profileButton.Margin = new Padding(2);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(94, 23);
            profileButton.TabIndex = 4;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            // 
            // softwareButton
            // 
            softwareButton.Location = new Point(1, 98);
            softwareButton.Margin = new Padding(2);
            softwareButton.Name = "softwareButton";
            softwareButton.Size = new Size(94, 25);
            softwareButton.TabIndex = 5;
            softwareButton.Text = "Software";
            softwareButton.UseVisualStyleBackColor = true;
            softwareButton.Click += softwareButton_Click;
            // 
            // vendorButton
            // 
            vendorButton.Location = new Point(1, 136);
            vendorButton.Margin = new Padding(2);
            vendorButton.Name = "vendorButton";
            vendorButton.Size = new Size(94, 22);
            vendorButton.TabIndex = 6;
            vendorButton.Text = "Vendor";
            vendorButton.UseVisualStyleBackColor = true;
            // 
            // NotificationButton
            // 
            NotificationButton.Location = new Point(1, 173);
            NotificationButton.Margin = new Padding(2);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new Size(94, 23);
            NotificationButton.TabIndex = 7;
            NotificationButton.Text = "Notifications";
            NotificationButton.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Review due for the wealth management category ";
            notifyIcon1.BalloonTipTitle = "Review";
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // softwareContainerLayoutPanel
            // 
            softwareContainerLayoutPanel.AutoScroll = true;
            softwareContainerLayoutPanel.Location = new Point(269, 64);
            softwareContainerLayoutPanel.Name = "softwareContainerLayoutPanel";
            softwareContainerLayoutPanel.Size = new Size(596, 488);
            softwareContainerLayoutPanel.TabIndex = 8;
            // 
            // HomepageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1049, 577);
            Controls.Add(softwareContainerLayoutPanel);
            Controls.Add(NotificationButton);
            Controls.Add(vendorButton);
            Controls.Add(softwareButton);
            Controls.Add(profileButton);
            Controls.Add(logoLabel);
            Controls.Add(searchTxtBox);
            Margin = new Padding(2);
            Name = "HomepageForm";
            Text = "HomepageForm";
            Load += HomepageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTxtBox;
        private Button searchButton;
        private Label logoLabel;
        private Button profileButton;
        private Button softwareButton;
        private Button vendorButton;
        private Button NotificationButton;
        private Label wealthMLabel;
        private PictureBox watsonPicBox;
        private PictureBox ezopsPicBox;
        private PictureBox appianPicBox;
        private PictureBox adonisPicBox;
        private PictureBox liminaPicBox;
        private PictureBox addeparPicBox;
        private Label dataManagLabel;
        private PictureBox finbournePicBox;
        private Label investmentBanLabel;
        private PictureBox coherentPicBox;
        private Label assetManaLabel;
        private NotifyIcon notifyIcon1;
        private FlowLayoutPanel softwareContainerLayoutPanel;
    }
}