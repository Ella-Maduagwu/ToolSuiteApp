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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listofVendors_Load(object sender, EventArgs e)
        {

        }

        private void vend_btn_Click(object sender, EventArgs e)
        {
            // Open the Vendors page
            VendorsForm vendorsForm = new VendorsForm();
            vendorsForm.ShowDialog();
        }
        private void acc_btn_Click(object sender, EventArgs e)
        {
           //opens acc page
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
            userRepository = new UserRepository();
            LoadData();
        }

        private void LoadData()
        {
            // Fetch vendors and categories from the database
            List<Vendor> vendors = userRepository.GetVendors();
            List<Category> categories = userRepository.GetCategories();

            // Set up columns for the vendors DataGridView
            dataGridViewVendors.AutoGenerateColumns = false;
            dataGridViewVendors.DataSource = vendors;

            DataGridViewTextBoxColumn vendorColumn = new DataGridViewTextBoxColumn();
            vendorColumn.DataPropertyName = "VendorName"; // Replace with the actual property name in your Vendor class
            vendorColumn.HeaderText = "Vendor";
            dataGridViewVendors.Columns.Add(vendorColumn);

            // Set up columns for the categories DataGridView
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.DataSource = categories;

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.DataPropertyName = "CategoryName"; // Replace with the actual property name in your Category class
            categoryColumn.HeaderText = "Category";
            dataGridViewCategories.Columns.Add(categoryColumn);

        }
        private void edit_btn_Click(object sender, EventArgs e)
        {

        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            // Open the Staff page
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }

        private void notif_btn_Click(object sender, EventArgs e)
        {
            // Open the Notifications page
            NotificationsForm notificationsForm = new NotificationsForm();
            notificationsForm.ShowDialog();
        }

        private void soft_btn_Click(object sender, EventArgs e)
        {
            // Open the Softwares page
            SoftwaresForm softwaresForm = new SoftwaresForm();
            softwaresForm.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
