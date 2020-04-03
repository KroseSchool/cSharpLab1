using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Project:Picture box
Name:   Kevin Rose
Date:   3/31/2020

Purpose:
Displays picture of number when user clicks on corresponding label.
Clear button will reset form, showing no number pictures.
Exit button will display prompt, notifying user that program will terminate, then exit program.
*/

namespace lab1KevinRose
{
    public partial class lab1KevinRose : Form
    {

        public lab1KevinRose()
        {
            // Initialize PictureBoxForm from Form generic Form Class.
            InitializeComponent();
        }


        public void clearPictureBoxes()
        {
            // turns all pictures on form invisible
            firstPictureBox.Visible = false;
            secondPictureBox.Visible = false;
            thirdPictureBox.Visible = false;
            fourthPictureBox.Visible = false;
            fifthPictureBox.Visible = false;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // on exit button click, will close form, after notifying user via dialogue box
            MessageBox.Show("This will terminate the program");
            this.Close();
        }

        
        private void clearButton_Click(object sender, EventArgs e)
        {
            // calls clearPictureBoxes, which turns visibility property off for all pictureboxes
            clearPictureBoxes();
        }

        private void fristPictureLabel_Click(object sender, EventArgs e)
        {
            // on click of first pics label, clear PictureBoxes, show only first pic
            clearPictureBoxes();
            firstPictureBox.Visible = true;
        }
        
        private void secondPictureLabel_Click(object sender, EventArgs e)
        {
            // on click of second pic label, clear PictureBoxes, show only second pic
            clearPictureBoxes();
            secondPictureBox.Visible = true;
        }


        private void thirdPictureLabel_Click(object sender, EventArgs e)
        {
            // on click of third pic label, clear PictureBoxes, show only third pic
            clearPictureBoxes();
            thirdPictureBox.Visible = true;
        }

       
        private void fourthPictureLabel_Click(object sender, EventArgs e)
        {
            // on click of fourth pic label, clear PictureBoxes, show only fourth pic
            clearPictureBoxes();
            fourthPictureBox.Visible = true;
        }
        
        private void fifthPictureLabel_Click(object sender, EventArgs e)
        {
            // on click of fifth pic label, clear PictureBoxes, show only fifth pic
            clearPictureBoxes();
            fifthPictureBox.Visible = true;
        }
    }
}
