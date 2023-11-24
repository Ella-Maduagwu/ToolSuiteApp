using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolsuiteapp.View
{
    public partial class WealthMAnagementForm : Form
    {
        public WealthMAnagementForm()
        {
            InitializeComponent();
        }

        private void addeparDescription_Click(object sender, EventArgs e)
        {
            // ignore this 
        }

        private void editLabel_Click(object sender, EventArgs e)
        {
            // only show this to the user with admin permission
            //  bind all the edit events together 
            // you could consider using a list 
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // create and open the wishlist form window here
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // change the window back to the software categories form window 
        }
    }
}
