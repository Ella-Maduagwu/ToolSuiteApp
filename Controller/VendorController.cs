using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolsuiteapp.Controller
{
    public class VendorController
    {
        private VendorModel _model;

        public VendorController(VendorModel model)
        {
            _model = model;
        }

        public void ShowAccountsForm()
        {
         
            AccountsForm accountsForm = new AccountsForm();
            accountsForm.Show();
        }

        public void ShowSoftwaresForm()
        {
            
            SoftwaresForm softwaresForm = new SoftwaresForm();
            softwaresForm.Show();
        }
        public void ShowVendorsForm()
        {
            
            VendorsForm softwaresForm = new VendorsForm();
            softwaresForm.Show();
        }
        public void ShowNotificationsForm()
        {
           
            NotificationsForm softwaresForm = new NotificationsForm();
            softwaresForm.Show();
        }
        public void ShowStaffForm()
        {
         
            StaffForm softwaresForm = new StaffForm();
            softwaresForm.Show();
        }
    }
}