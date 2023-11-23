namespace toolsuiteapp.View
{
    partial class listofVendors
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
            panel1 = new Panel();
            staff_btn = new Button();
            notif_btn = new Button();
            vend_btn = new Button();
            soft_btn = new Button();
            acc_btn = new Button();
            dataGridViewVendors = new DataGridView();
            Vendors = new DataGridViewTextBoxColumn();
            edit_btn = new Button();
            dataGridViewCategories = new DataGridView();
            Categories = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(staff_btn);
            panel1.Controls.Add(notif_btn);
            panel1.Controls.Add(vend_btn);
            panel1.Controls.Add(soft_btn);
            panel1.Controls.Add(acc_btn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 302);
            panel1.TabIndex = 0;
            // 
            // staff_btn
            // 
            staff_btn.Location = new Point(36, 152);
            staff_btn.Name = "staff_btn";
            staff_btn.Size = new Size(94, 29);
            staff_btn.TabIndex = 4;
            staff_btn.Text = "Staff";
            staff_btn.UseVisualStyleBackColor = true;
            staff_btn.Click += staff_btn_Click;
            // 
            // notif_btn
            // 
            notif_btn.Location = new Point(36, 117);
            notif_btn.Name = "notif_btn";
            notif_btn.Size = new Size(105, 29);
            notif_btn.TabIndex = 3;
            notif_btn.Text = "Notifications";
            notif_btn.UseVisualStyleBackColor = true;
            notif_btn.Click += notif_btn_Click;
            // 
            // vend_btn
            // 
            vend_btn.Location = new Point(36, 82);
            vend_btn.Name = "vend_btn";
            vend_btn.Size = new Size(94, 29);
            vend_btn.TabIndex = 2;
            vend_btn.Text = "Vendors";
            vend_btn.UseVisualStyleBackColor = true;
            vend_btn.Click += vend_btn_Click;
            // 
            // soft_btn
            // 
            soft_btn.Location = new Point(36, 47);
            soft_btn.Name = "soft_btn";
            soft_btn.Size = new Size(94, 29);
            soft_btn.TabIndex = 1;
            soft_btn.Text = "Softwares";
            soft_btn.UseVisualStyleBackColor = true;
            soft_btn.Click += soft_btn_Click;
            // 
            // acc_btn
            // 
            acc_btn.Location = new Point(36, 12);
            acc_btn.Name = "acc_btn";
            acc_btn.Size = new Size(94, 29);
            acc_btn.TabIndex = 0;
            acc_btn.Text = "Account";
            acc_btn.UseVisualStyleBackColor = true;
            acc_btn.Click += acc_btn_Click;
            // 
            // dataGridViewVendors
            // 
            dataGridViewVendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendors.Columns.AddRange(new DataGridViewColumn[] { Vendors });
            dataGridViewVendors.Location = new Point(278, 47);
            dataGridViewVendors.Name = "dataGridViewVendors";
            dataGridViewVendors.RowHeadersWidth = 51;
            dataGridViewVendors.RowTemplate.Height = 29;
            dataGridViewVendors.Size = new Size(178, 255);
            dataGridViewVendors.TabIndex = 1;
            dataGridViewVendors.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Vendors
            // 
            Vendors.HeaderText = "Vendor";
            Vendors.MinimumWidth = 6;
            Vendors.Name = "Vendors";
            Vendors.Width = 125;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(306, 308);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(94, 29);
            edit_btn.TabIndex = 5;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { Categories });
            dataGridViewCategories.Location = new Point(444, 47);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.RowTemplate.Height = 29;
            dataGridViewCategories.Size = new Size(192, 255);
            dataGridViewCategories.TabIndex = 6;
            dataGridViewCategories.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Categories
            // 
            Categories.HeaderText = "Category";
            Categories.MinimumWidth = 6;
            Categories.Name = "Categories";
            Categories.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(492, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // listofVendors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewCategories);
            Controls.Add(edit_btn);
            Controls.Add(dataGridViewVendors);
            Controls.Add(panel1);
            Name = "listofVendors";
            Text = "listofVendors";
            Load += listofVendors_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button staff_btn;
        private Button notif_btn;
        private Button vend_btn;
        private Button soft_btn;
        private Button acc_btn;
        private DataGridView dataGridViewVendors;
        private Button edit_btn;
        private DataGridViewTextBoxColumn Vendors;
        private DataGridView dataGridViewCategories;
        private DataGridViewTextBoxColumn Categories;
        private Button button1;
    }
}