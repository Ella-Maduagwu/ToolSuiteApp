namespace toolsuiteapp.View
{
    partial class WealthMAnagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WealthMAnagementForm));
            label1 = new Label();
            addeparPic = new PictureBox();
            wealthManagementLabl = new Label();
            process1 = new System.Diagnostics.Process();
            changesCheckBox = new CheckBox();
            addeparDescription = new Label();
            editLabel = new Label();
            liminiPicBox = new PictureBox();
            liminaDescription = new Label();
            LaminaWishCheckBox = new CheckBox();
            laminaEditLabel = new Label();
            nextButton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)addeparPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liminiPicBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // addeparPic
            // 
            addeparPic.Image = (Image)resources.GetObject("addeparPic.Image");
            addeparPic.Location = new Point(70, 174);
            addeparPic.Name = "addeparPic";
            addeparPic.Size = new Size(273, 266);
            addeparPic.SizeMode = PictureBoxSizeMode.StretchImage;
            addeparPic.TabIndex = 1;
            addeparPic.TabStop = false;
            // 
            // wealthManagementLabl
            // 
            wealthManagementLabl.AutoSize = true;
            wealthManagementLabl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            wealthManagementLabl.Location = new Point(44, 61);
            wealthManagementLabl.Name = "wealthManagementLabl";
            wealthManagementLabl.Size = new Size(258, 32);
            wealthManagementLabl.TabIndex = 2;
            wealthManagementLabl.Text = "Wealth Management ";
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // changesCheckBox
            // 
            changesCheckBox.AutoSize = true;
            changesCheckBox.Location = new Point(765, 174);
            changesCheckBox.Name = "changesCheckBox";
            changesCheckBox.Size = new Size(165, 29);
            changesCheckBox.TabIndex = 4;
            changesCheckBox.Text = "Add to Wishlist ";
            changesCheckBox.UseVisualStyleBackColor = true;
            // 
            // addeparDescription
            // 
            addeparDescription.AutoSize = true;
            addeparDescription.BackColor = SystemColors.HighlightText;
            addeparDescription.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addeparDescription.ForeColor = SystemColors.Desktop;
            addeparDescription.Location = new Point(349, 365);
            addeparDescription.Name = "addeparDescription";
            addeparDescription.Size = new Size(444, 42);
            addeparDescription.TabIndex = 5;
            addeparDescription.Text = "Addepar empowers investment professionals across the globe \r\nwith data,insights and cutting-edge technology";
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.ForeColor = SystemColors.Highlight;
            editLabel.Location = new Point(782, 439);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(42, 25);
            editLabel.TabIndex = 6;
            editLabel.Text = "Edit";
            editLabel.Click += editLabel_Click;
            // 
            // liminiPicBox
            // 
            liminiPicBox.Image = (Image)resources.GetObject("liminiPicBox.Image");
            liminiPicBox.Location = new Point(70, 688);
            liminiPicBox.Name = "liminiPicBox";
            liminiPicBox.Size = new Size(273, 285);
            liminiPicBox.TabIndex = 7;
            liminiPicBox.TabStop = false;
            // 
            // liminaDescription
            // 
            liminaDescription.AutoSize = true;
            liminaDescription.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            liminaDescription.Location = new Point(349, 874);
            liminaDescription.Name = "liminaDescription";
            liminaDescription.Size = new Size(341, 84);
            liminaDescription.TabIndex = 8;
            liminaDescription.Text = "Limina Investment Management Solution (IMS) \r\nis an open platform that helps Asset Managers:\r\nOvercome fragmented workflows\r\nIncrease confidence in data and oversight\r\n";
            // 
            // LaminaWishCheckBox
            // 
            LaminaWishCheckBox.AutoSize = true;
            LaminaWishCheckBox.Location = new Point(795, 680);
            LaminaWishCheckBox.Name = "LaminaWishCheckBox";
            LaminaWishCheckBox.Size = new Size(160, 29);
            LaminaWishCheckBox.TabIndex = 9;
            LaminaWishCheckBox.Text = "Add to Wishlist";
            LaminaWishCheckBox.UseVisualStyleBackColor = true;
            // 
            // laminaEditLabel
            // 
            laminaEditLabel.AutoSize = true;
            laminaEditLabel.ForeColor = SystemColors.MenuHighlight;
            laminaEditLabel.Location = new Point(811, 924);
            laminaEditLabel.Name = "laminaEditLabel";
            laminaEditLabel.Size = new Size(42, 25);
            laminaEditLabel.TabIndex = 10;
            laminaEditLabel.Text = "Edit";
            // 
            // nextButton
            // 
            nextButton.ForeColor = SystemColors.Highlight;
            nextButton.Location = new Point(1421, 1229);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 11;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(70, 1229);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 34);
            backButton.TabIndex = 12;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // WealthMAnagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1623, 1410);
            Controls.Add(backButton);
            Controls.Add(nextButton);
            Controls.Add(laminaEditLabel);
            Controls.Add(LaminaWishCheckBox);
            Controls.Add(liminaDescription);
            Controls.Add(liminiPicBox);
            Controls.Add(editLabel);
            Controls.Add(addeparDescription);
            Controls.Add(changesCheckBox);
            Controls.Add(wealthManagementLabl);
            Controls.Add(addeparPic);
            Controls.Add(label1);
            Name = "WealthMAnagementForm";
            Text = "WealthMAnagementForm";
            ((System.ComponentModel.ISupportInitialize)addeparPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)liminiPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox addeparPic;
        private Label wealthManagementLabl;
        private System.Diagnostics.Process process1;
        private CheckBox changesCheckBox;
        private Label addeparDescription;
        private Label editLabel;
        private PictureBox liminiPicBox;
        private Label liminaDescription;
        private Label laminaEditLabel;
        private CheckBox LaminaWishCheckBox;
        private Button backButton;
        private Button nextButton;
    }
}