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
        
        public SoftwareCategoriesForm()
        {
           
            InitializeComponent();
            UserSession userSession = new UserSession();
            string userRole = userSession.GetRole();
            AddBtn.Visible = false;// hide the add button
            UserRepository userRepository = new UserRepository();
            this.categoriesController = new CategoriesController(this, userRepository);
            var categories = userRepository.GetSoftwareCategories();
            if (categories != null)
            {
              
            }
           
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

                };

                this.Controls.Add(newButton);

                if (userRole == "Admin")
                {
                    AddBtn.Visible = true;// only make the add button visible if the currentuser has admin rights
                }
                
            }
        }

        

        // allow for adding, editing and deleting 


        private void LogoButton_Click(object sender, EventArgs e)
        {
            HomepageForm homepageForm = new();
            this.Hide();
            homepageForm.ShowDialog();
            this.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            this.Hide();
            addCategoryForm.ShowDialog();
            this.Close();
        }



       

        
    }
}
