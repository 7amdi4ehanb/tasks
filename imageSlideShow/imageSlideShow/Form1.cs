using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imageSlideShow
{
    public partial class Form1 : Form
    {
        
        List<string> imagePaths = new List<string> {
            "E:\\FCI\\Tasks\\visual programming\\imageSlideShow\\pics\\1.jpg",
            "E:\\FCI\\Tasks\\visual programming\\imageSlideShow\\pics\\2.jpg",
            "E:\\FCI\\Tasks\\visual programming\\imageSlideShow\\pics\\3.jpg"
        };

        int img_indx = 0;

        public Form1()
        {
            InitializeComponent();
            SlideImage();
        }

        private void SlideImage()
        {
            if (imagePaths.Count > 0)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePaths[img_indx]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (img_indx > 0)
            {
                img_indx--;
                SlideImage();
            }
            else
            {
                MessageBox.Show("I Cannot Found previous images");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (img_indx < imagePaths.Count - 1)
            {
                img_indx++;
                SlideImage();
            }
            else
            {
                MessageBox.Show("I Cannot Found Next images");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SlideImage();
        }
    }
}
