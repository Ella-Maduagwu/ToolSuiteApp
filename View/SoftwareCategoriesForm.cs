using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;
using toolsuiteapp.Data;
using toolsuiteapp.Model;
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class SoftwareCategoriesForm : Form
    {
        private CategoriesController categoriesController;
        private UserSession _userSession;
        
        public SoftwareCategoriesForm(UserSession userSession)
        {
           
            InitializeComponent();
            _userSession = userSession;
            UserRepository userRepository = new UserRepository();
            this.categoriesController = new CategoriesController(userRepository);
            var categories = userRepository.GetSoftwareCategories();
            string currentUser = userSession.GetRole();
           
            int yOffSet = 248;
            
            foreach (var category in categories)
            {
               
                Button newButton = new Button
                {

                    Text = category.Name,
                    Location = new Point(128, yOffSet),
                    Size = new Size(198, 40)
                };
                yOffSet += 69;
                // add click event to button 
                newButton.Click += (sender, e) =>
                {
                    UserRepository userRepository = new UserRepository();
                    userRepository.GetSoftwares(category.Name);
                    AssetManagementForm form = new AssetManagementForm();
                    Specific
                    form.ShowDialog();
                };

                this.Controls.Add(newButton);
               
                
            }

            if (currentUser == "Admin")
            {
                AddBtn.Visible = true;
            }
        }

        

        // allow for adding, editing and deleting 


        private void LogoButton_Click(object sender, EventArgs e)
        {
            HomepageForm homepageForm = new(_userSession);
            this.Hide();
            homepageForm.ShowDialog();
            this.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            AddCategoryForm addCategoryForm = new AddCategoryForm(userRepository);
            this.Hide();
            addCategoryForm.ShowDialog();
            this.Close();
        }



       

        
    }
}
