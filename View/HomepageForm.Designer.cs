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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            searchTxtBox = new TextBox();
            searchButton = new Button();
            logoLabel = new Label();
            profileButton = new Button();
            softwareButton = new Button();
            vendorButton = new Button();
            NotificationButton = new Button();
            panel1 = new Panel();
            assetManaLabel = new Label();
            coherentPicBox = new PictureBox();
            investmentBanLabel = new Label();
            finbournePicBox = new PictureBox();
            dataManagLabel = new Label();
            wealthMLabel = new Label();
            watsonPicBox = new PictureBox();
            ezopsPicBox = new PictureBox();
            appianPicBox = new PictureBox();
            adonisPicBox = new PictureBox();
            liminaPicBox = new PictureBox();
            addeparPicBox = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coherentPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finbournePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)watsonPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ezopsPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appianPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adonisPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liminaPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addeparPicBox).BeginInit();
            SuspendLayout();
            // 
            // searchTxtBox
            // 
            searchTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchTxtBox.Location = new Point(351, 18);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(733, 31);
            searchTxtBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Right;
            searchButton.Location = new Point(1106, 18);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(174, 36);
            searchButton.TabIndex = 1;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Playbill", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logoLabel.Location = new Point(3, 26);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(83, 28);
            logoLabel.TabIndex = 3;
            logoLabel.Text = "CITISOFT";
            // 
            // profileButton
            // 
            profileButton.Location = new Point(2, 107);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(134, 38);
            profileButton.TabIndex = 4;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // softwareButton
            // 
            softwareButton.Location = new Point(2, 163);
            softwareButton.Name = "softwareButton";
            softwareButton.Size = new Size(134, 42);
            softwareButton.TabIndex = 5;
            softwareButton.Text = "Software";
            softwareButton.UseVisualStyleBackColor = true;
            softwareButton.Click += SoftwareButton_Click;
            // 
            // vendorButton
            // 
            vendorButton.Location = new Point(2, 227);
            vendorButton.Name = "vendorButton";
            vendorButton.Size = new Size(134, 37);
            vendorButton.TabIndex = 6;
            vendorButton.Text = "Vendor";
            vendorButton.UseVisualStyleBackColor = true;
            vendorButton.Click += vendorButton_Click;
            // 
            // NotificationButton
            // 
            NotificationButton.Location = new Point(2, 289);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new Size(134, 38);
            NotificationButton.TabIndex = 7;
            NotificationButton.Text = "Notifications";
            NotificationButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(assetManaLabel);
            panel1.Controls.Add(coherentPicBox);
            panel1.Controls.Add(investmentBanLabel);
            panel1.Controls.Add(finbournePicBox);
            panel1.Controls.Add(dataManagLabel);
            panel1.Controls.Add(wealthMLabel);
            panel1.Controls.Add(watsonPicBox);
            panel1.Controls.Add(ezopsPicBox);
            panel1.Controls.Add(appianPicBox);
            panel1.Controls.Add(adonisPicBox);
            panel1.Controls.Add(liminaPicBox);
            panel1.Controls.Add(addeparPicBox);
            panel1.Location = new Point(140, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 340);
            panel1.TabIndex = 8;
            panel1.Click += Panel1_Click;
            // 
            // assetManaLabel
            // 
            assetManaLabel.AutoSize = true;
            assetManaLabel.Location = new Point(772, 39);
            assetManaLabel.Name = "assetManaLabel";
            assetManaLabel.Size = new Size(192, 25);
            assetManaLabel.TabIndex = 15;
            assetManaLabel.Text = "Asset Management   >";
            assetManaLabel.Click += AssetManaLabel_Click;
            // 
            // coherentPicBox
            // 
            coherentPicBox.Image = (Image)resources.GetObject("coherentPicBox.Image");
            coherentPicBox.Location = new Point(371, 74);
            coherentPicBox.Name = "coherentPicBox";
            coherentPicBox.Size = new Size(229, 225);
            coherentPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coherentPicBox.TabIndex = 14;
            coherentPicBox.TabStop = false;
            coherentPicBox.Click += CoherentPicBox_Click;
            // 
            // investmentBanLabel
            // 
            investmentBanLabel.AutoSize = true;
            investmentBanLabel.Location = new Point(373, 31);
            investmentBanLabel.Name = "investmentBanLabel";
            investmentBanLabel.Size = new Size(191, 25);
            investmentBanLabel.TabIndex = 13;
            investmentBanLabel.Text = "Investment banking  >";
            investmentBanLabel.Click += InvestmentBanLabel_Click;
            // 
            // finbournePicBox
            // 
            finbournePicBox.Image = (Image)resources.GetObject("finbournePicBox.Image");
            finbournePicBox.Location = new Point(1119, 74);
            finbournePicBox.Name = "finbournePicBox";
            finbournePicBox.Size = new Size(214, 225);
            finbournePicBox.TabIndex = 12;
            finbournePicBox.TabStop = false;
            finbournePicBox.Click += FinbournePicBox_Click;
            // 
            // dataManagLabel
            // 
            dataManagLabel.AutoSize = true;
            dataManagLabel.Location = new Point(1121, 28);
            dataManagLabel.Name = "dataManagLabel";
            dataManagLabel.Size = new Size(181, 25);
            dataManagLabel.TabIndex = 11;
            dataManagLabel.Text = "Data Management  >";
            dataManagLabel.Click += DataManagLabel_Click;
            // 
            // wealthMLabel
            // 
            wealthMLabel.AutoSize = true;
            wealthMLabel.Location = new Point(11, 23);
            wealthMLabel.Name = "wealthMLabel";
            wealthMLabel.Size = new Size(198, 25);
            wealthMLabel.TabIndex = 8;
            wealthMLabel.Text = "Wealth Management  >";
            wealthMLabel.Click += WealthMLabel_Click;
            // 
            // watsonPicBox
            // 
            watsonPicBox.Image = (Image)resources.GetObject("watsonPicBox.Image");
            watsonPicBox.Location = new Point(1119, 338);
            watsonPicBox.Name = "watsonPicBox";
            watsonPicBox.Size = new Size(229, 194);
            watsonPicBox.TabIndex = 7;
            watsonPicBox.TabStop = false;
            watsonPicBox.Click += WatsonPicBox_Click;
            // 
            // ezopsPicBox
            // 
            ezopsPicBox.Image = (Image)resources.GetObject("ezopsPicBox.Image");
            ezopsPicBox.Location = new Point(773, 338);
            ezopsPicBox.Name = "ezopsPicBox";
            ezopsPicBox.Size = new Size(259, 194);
            ezopsPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ezopsPicBox.TabIndex = 6;
            ezopsPicBox.TabStop = false;
            ezopsPicBox.Click += EzopsPicBox_Click;
            // 
            // appianPicBox
            // 
            appianPicBox.Image = (Image)resources.GetObject("appianPicBox.Image");
            appianPicBox.Location = new Point(371, 338);
            appianPicBox.Name = "appianPicBox";
            appianPicBox.Size = new Size(229, 194);
            appianPicBox.TabIndex = 5;
            appianPicBox.TabStop = false;
            appianPicBox.Click += AppianPicBox_Click;
            // 
            // adonisPicBox
            // 
            adonisPicBox.Image = (Image)resources.GetObject("adonisPicBox.Image");
            adonisPicBox.Location = new Point(773, 74);
            adonisPicBox.Name = "adonisPicBox";
            adonisPicBox.Size = new Size(259, 225);
            adonisPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            adonisPicBox.TabIndex = 3;
            adonisPicBox.TabStop = false;
            adonisPicBox.Click += AdonisPicBox_Click;
            // 
            // liminaPicBox
            // 
            liminaPicBox.Image = (Image)resources.GetObject("liminaPicBox.Image");
            liminaPicBox.Location = new Point(-29, 338);
            liminaPicBox.Name = "liminaPicBox";
            liminaPicBox.Size = new Size(229, 194);
            liminaPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            liminaPicBox.TabIndex = 1;
            liminaPicBox.TabStop = false;
            liminaPicBox.Click += LiminaPicBox_Click;
            // 
            // addeparPicBox
            // 
            addeparPicBox.Image = (Image)resources.GetObject("addeparPicBox.Image");
            addeparPicBox.Location = new Point(-29, 74);
            addeparPicBox.Name = "addeparPicBox";
            addeparPicBox.Size = new Size(225, 225);
            addeparPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            addeparPicBox.TabIndex = 0;
            addeparPicBox.TabStop = false;
            addeparPicBox.Click += AddeparPictBox_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Review due for the wealth management category ";
            notifyIcon1.BalloonTipTitle = "Review";
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // HomepageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1499, 961);
            Controls.Add(panel1);
            Controls.Add(NotificationButton);
            Controls.Add(vendorButton);
            Controls.Add(softwareButton);
            Controls.Add(profileButton);
            Controls.Add(logoLabel);
            Controls.Add(searchButton);
            Controls.Add(searchTxtBox);
            Name = "HomepageForm";
            Text = "HomepageForm";
            Load += HomepageForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coherentPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)finbournePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)watsonPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ezopsPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)appianPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)adonisPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)liminaPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)addeparPicBox).EndInit();
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
        private Panel panel1;
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
    }
}