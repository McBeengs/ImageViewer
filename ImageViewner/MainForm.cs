using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewner
{
	public partial class MainForm : Form
	{

		private Boolean isFullscreen = false;

		public MainForm()
		{
			InitializeComponent();
		}

		private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "All images (*.jpg, *.bmp, *.png, *.gif)|*.jpg;*.bmp;*.png;*.gif| jpg (*.jpg)|*.jpg| bmp (*.bmp)|*.bmp| png (*.png)|*.png| gif (*.gif)|*.gif";
            ofd.Multiselect = false;

			if (ofd.ShowDialog().Equals(DialogResult.OK) && ofd.FileName.Length > 0)
			{
				setImage(ofd.FileName);
			}
		}

        private void openMultipleImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All images (*.jpg, *.bmp, *.png, *.gif)|*.jpg;*.bmp;*.png;*.gif| jpg (*.jpg)|*.jpg| bmp (*.bmp)|*.bmp| png (*.png)|*.png| gif (*.gif)|*.gif";
            ofd.Multiselect = true;

            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                if (ofd.FileNames.Length <= 1)
                {
                    setImage(ofd.FileName);
                } else
                {
                    rightButton.Visible = true;
                    leftButton.Visible = true;

                    //ofd.
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void setImage(String filename)
		{
			imageDisplayer.SizeMode = PictureBoxSizeMode.Zoom;
			imageDisplayer.Image = Image.FromFile(filename);
		}

		private void imageDisplayer_DoubleClick(object sender, EventArgs e)
		{
			//Console.WriteLine("double click");
			goFullscreen();
		}

		private void goFullscreen()
		{
			if (!isFullscreen)
			{
				WindowState = FormWindowState.Normal;
				FormBorderStyle = FormBorderStyle.None;
				Bounds = Screen.PrimaryScreen.Bounds;
                menuStrip1.Visible = false;
				isFullscreen = true;
			}
			else
			{
				WindowState = FormWindowState.Normal;
				FormBorderStyle = FormBorderStyle.Sizable;
                menuStrip1.Visible = true;
				Height = 400;
				Width = 500;
				CenterToScreen();
				isFullscreen = false;
			}
		}

		private void leftButton_Click(object sender, EventArgs e)
		{
			Console.WriteLine("left");
		}

		private void rightButton_Click(object sender, EventArgs e)
		{
			Console.WriteLine("right");
		}

        private void zoomMore_Click(object sender, EventArgs e)
        {
            Console.WriteLine("more");
        }

        private void zoomLess_Click(object sender, EventArgs e)
        {
            Console.WriteLine("less");
        }
    }
}
