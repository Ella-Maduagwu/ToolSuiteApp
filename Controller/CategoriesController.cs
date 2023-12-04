using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.Data;
using toolsuiteapp.Model;
using toolsuiteapp.View;

namespace toolsuiteapp.Controller
{
    public  class CategoriesController
    {
        private SoftwareCategoriesForm view;// initialization
        private UserRepository userRepository;
        public CategoriesController(SoftwareCategoriesForm view, UserRepository userRepository)
        {
            this.view = view;
            this.userRepository = userRepository;

            LoadCategories();// fetches software categories through UserRepository 
        }

        public void LoadCategories()
        {
            var categories = userRepository.GetSoftwareCategories();
           
        }

        public void SaveCategories(SoftwareCategoriesModel category)
        {
            if (category.Id > 0)
            {
                userRepository.UpdateCategory(category);// updates a
            }
            else
            {
                userRepository.AddCategory(category);// adds new category to the db
               
            }
            LoadCategories();// refresh the list

        }

        public void DeleteCategory(SoftwareCategoriesModel category)
        {
            userRepository.DeleteCategory(category);
            LoadCategories();// refresh the list
        }

    }
}
