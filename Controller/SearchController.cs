using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.Data;
using toolsuiteapp.View;

namespace toolsuiteapp.Controller
{
    public class SearchController
    {
        private HomepageForm view;
     
        private SearchToFormMapper formMapper;
        public SearchController(HomepageForm view, UserRepository userRepository)
        {
            this.view = view;
          
            this.formMapper = new SearchToFormMapper();
        }

        public void PerformSearchAndOpenForm(string searchTerm)
        {
            // perform the search logic, create an object of the model class
            Type formType = formMapper.GetFormTypeForSearchTerm(searchTerm);
            if (formType != null)
            {
                Form formToOpen = (Form)Activator.CreateInstance(formType);
                formToOpen.ShowDialog();
            }
            else
            {
                FourOFourFormPage fourO = new FourOFourFormPage();
                fourO.ShowDialog();
            }
           
        }
    }
}
