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
            LogoButton = new Button();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // LogoButton
            // 
            LogoButton.Font = new Font("Forte", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogoButton.Location = new Point(139, 55);
            LogoButton.Name = "LogoButton";
            LogoButton.Size = new Size(98, 40);
            LogoButton.TabIndex = 2;
            LogoButton.Text = "Citisoft";
            LogoButton.UseVisualStyleBackColor = true;
            LogoButton.Click += LogoButton_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(978, 55);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(79, 40);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "Add +";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SoftwareCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 1299);
            Controls.Add(AddBtn);
            Controls.Add(LogoButton);
            Name = "SoftwareCategoriesForm";
            Text = "SoftwareCategoriesForm";
            ResumeLayout(false);
        }

        #endregion
        private Button LogoButton;
        private Button AddBtn;
    }
}