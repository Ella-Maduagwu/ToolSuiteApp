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



        private void nextButton_Click(object sender, EventArgs e)
        {
            // create and open the wishlist form window here
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // change the window back to the software categories form window 
        }

        private void addeparPic_Click(object sender, EventArgs e)
        {
            // retrieve the category of this software
            // display items in the same category under related results 
            /* this is the logo pic of the first company in wealth manageement category
             the pic is clickable and opens up the info page of the software of which you clicked it's pic
             create a form for the 'admin software info page' that's on the figma 
            handle this events to open that window form
            keep in mind, this form is where the website link is in, the photo of the software is also in this form
            last review date and demo is here too
            pdf is here too
            and lastly screenshots 
            for every software in each category, do this
            */
        }

        private void changesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WishlistForm form = new WishlistForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
