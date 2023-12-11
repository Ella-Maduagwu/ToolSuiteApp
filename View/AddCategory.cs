using toolsuiteapp.Controller;
using toolsuiteapp.Data;
using toolsuiteapp.Model;
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class AddCategoryForm : Form
    {

        CategoriesController _categoriesController;
        SoftwareCategoriesForm _categoriesForm;
        public AddCategoryForm()
        {
            InitializeComponent();
            _categoriesController = new CategoriesController();
            _categoriesForm = new SoftwareCategoriesForm();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            string ButtonName = CategoryNameTxtBox.Text;
            string SoftwareName1 = SoftwareNameTxtBox.Text;
            string VendorName1 = VendorNameTxtBox.Text;

            SoftwareCategoriesModel categories = new SoftwareCategoriesModel
            {
                Name = ButtonName,
                SoftwareName = SoftwareName1,
                VendorName = VendorName1
            };

            _categoriesController.SaveCategories(categories);

            MessageBox.Show("category created successfully");



        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _categoriesForm.ShowDialog();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AddSoftwareIntoCategories addSoftware = new AddSoftwareIntoCategories();
            Hide();
            addSoftware.ShowDialog();
            Close();
        }
    }
}