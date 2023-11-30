using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Data;
using toolsuiteapp.Model;

namespace toolsuiteapp.View
{
    public partial class listofVendors : Form
    {
        private UserRepository userRepository;

        public listofVendors()
        {
            InitializeComponent();
        }

        private void listofVendors_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void vend_btn_Click(object sender, EventArgs e)
        {
            VendorsForm vendorsForm = new VendorsForm();
            vendorsForm.ShowDialog();
        }

        private void acc_btn_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }

        private void notif_btn_Click(object sender, EventArgs e)
        {
            NotificationsForm notificationsForm = new NotificationsForm();
            notificationsForm.ShowDialog();
        }

        private void soft_btn_Click(object sender, EventArgs e)
        {
            SoftwaresForm softwaresForm = new SoftwaresForm();
            softwaresForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewVendors.Rows[e.RowIndex];

                
                string vendorName = row.Cells["VendorName"].Value.ToString();

                // Open the form for detailed vendor information
                TechFromVendorInfoForm techFromVendorInfoForm = new TechFromVendorInfoForm(vendorName);
                techFromVendorInfoForm.ShowDialog();
            }
        }

        private void LoadData()
        {
            List<Vendor> vendors = userRepository.GetVendors();
            List<Category> categories = userRepository.GetCategories();

            // Set up data for vendors
            dataGridViewVendors.AutoGenerateColumns = false;
            dataGridViewVendors.DataSource = vendors;

            DataGridViewTextBoxColumn vendorColumn = new DataGridViewTextBoxColumn();
            vendorColumn.DataPropertyName = "VendorName";
            vendorColumn.HeaderText = "Vendor";
            dataGridViewVendors.Columns.Add(vendorColumn);

            // Set up data for categories
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.DataSource = categories;

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.DataPropertyName = "CategoryName";
            categoryColumn.HeaderText = "Category";
            dataGridViewCategories.Columns.Add(categoryColumn);
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
