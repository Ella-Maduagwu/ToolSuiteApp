using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class SoftwareInfoBaseForm : Form
    {

        private bool editButtonClicked = false;
        public SoftwareInfoBaseForm()
        {
            InitializeComponent();

        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            editButtonClicked = true;
        }

        public void ScreenPicBox1_Click(object sender, EventArgs e)
        {
            UserSession userSession = new();
            string currentUser = userSession.GetRole();

            if (currentUser == "Admin")
            {
                EditButton.Visible = true;

                if (editButtonClicked)
                {
                    OpenFileDialog ofd = new();
                    ofd.Filter = "JPEG file|*.jpeg;*.jpeg";
                    if (ofd.ShowDialog() == DialogResult.OK)// this will open the file dialogue to enable the user choose a photo 
                    {
                        screenPicBox1.Image = new Bitmap(ofd.FileName);
                    }
                }
                // make the pictureBox editable for the admin

            }
            else
            {
                MessageBox.Show(Text, "Add to Wishlist?");
            }

        }

        public void WebsiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        // only if user role  == admin, show below method 

        public void websiteLabel_MouseUp(object sender, MouseEventArgs e)
        // this code below make the linkLabel editable
        // it is to be shown only when it the admin permission
        {
            if (e.Button == MouseButtons.Right)// when the linklabel is rightclicked
            {
                TextBox textbox = new();
                {// create a textbox at the same location as the linklabel and type your changes in it 
                    Size = websiteLabel.Size;
                    Location = websiteLabel.Location;
                    Text = websiteLabel.Text;
                };
                textbox.Leave += (s, e) =>
                {// exits when you click away from the link label
                    websiteLabel.Text = textbox.Text;// then saves the texbox input as new link label text 
                    textbox.Visible = false;
                };
                this.Controls.Add(textbox);
                textbox.BringToFront();
                textbox.Focus();
            }
        }


    }
}
