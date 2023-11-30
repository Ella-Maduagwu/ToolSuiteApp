﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Model;
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class SoftwareInfoBaseForm : Form
    {
        private readonly Software _software;

        private bool editButtonClicked = false;
        public SoftwareInfoBaseForm(Software software)
        {
            _software = software;

            InitializeComponent();

            if (!string.IsNullOrEmpty(_software.WebsiteUrl))
            {
                websiteLabel.Visible = true;
                websiteLabel.Enabled = true;
            }

            softwareNameLabel.Text = _software.Name;
            softwareImageBox.Image = Image.FromFile(_software.ImageUrl);
            softwareDescriptionTextBox.Text = _software.Description;

            if (!string.IsNullOrEmpty(_software.AdditionalInformation))
            {
                softwareAdditionalInfoLabel.Visible = true;
                softwareAdditionalInfoTextBox.Visible = true;
                softwareAdditionalInfoTextBox.Text = _software.AdditionalInformation;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            editButtonClicked = true;
        }

        public void screenPicBox1_Click(object sender, EventArgs e)
        {
            UserSession userSession = new UserSession();
            string currentUser = userSession.GetRole();

            if (currentUser == "Admin")
            {
                EditButton.Visible = true;

                if (editButtonClicked)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
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

        public void websiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                new ProcessStartInfo()
                {
                    FileName = _software.WebsiteUrl,
                    UseShellExecute = true
                }
            );
        }

        // only if user role  == admin, show below method 

        public void websiteLabel_MouseUp(object sender, MouseEventArgs e)
        // this code below make the linkLabel editable
        // it is to be shown only when it the admin permission
        {
            if (e.Button == MouseButtons.Right)// when the linklabel is rightclicked
            {
                TextBox textbox = new TextBox();
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
