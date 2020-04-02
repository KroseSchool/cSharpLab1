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
Displays pictures of numbers when user clicks on corresponding label.
Clear button will reset form, showing no number pictures.
Exit button will display prompt, notifying user that program will terminate, then exit program.

TODO
this. ?
names ?

*/

namespace lab1KevinRose
{
    public partial class myPictureBoxForm : Form
    {

        public myPictureBoxForm()
        {
            // Generate PictureBoxForm from Form generic Class.
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
            Close();
        }

        // calls clearPictureBoxes, which turns visibility property off for all pictureboxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearPictureBoxes();
        }

        // on click of first pics label, clear PictureBoxes, show only first pic
        private void fristPictureLabel_Click(object sender, EventArgs e)
        {
            clearPictureBoxes();
            firstPictureBox.Visible = true;
        }
        
        // on click of second pic label, clear PictureBoxes, show only second pic
        private void secondPictureLabel_Click(object sender, EventArgs e)
        {
            clearPictureBoxes();
            secondPictureBox.Visible = true;
        }

        // on click of third pic label, clear PictureBoxes, show only third pic
        private void thirdPictureLabel_Click(object sender, EventArgs e)
        {
            clearPictureBoxes();
            thirdPictureBox.Visible = true;
        }

        // on click of fourth pic label, clear PictureBoxes, show only fourth pic
        private void fourthPictureLabel_Click(object sender, EventArgs e)
        {
            clearPictureBoxes();
            fourthPictureBox.Visible = true;
        }
        // on click of fifth pic label, clear PictureBoxes, show only fifth pic
        private void fifthPictureLabel_Click(object sender, EventArgs e)
        {

            clearPictureBoxes();
            fifthPictureBox.Visible = true;
        }
    }
}
