using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewner
{
    public partial class MainForm : Form
    {

        private String file;
        private String[] multFiles;
        private int currentImage = 0;
        private Boolean isFullscreen = false;
        private Boolean isMultiFile = false;

        public MainForm()
        {
            InitializeComponent();
            MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            String[] args = Environment.GetCommandLineArgs();
            
            if (args.Length > 1)
            {
                String selected = args[1];
                if (args[1].Contains(".jpg") || args[1].Contains(".bmp") || args[1].Contains(".png") || args[1].Contains(".gif"))
                {
                    String[] getJpg = Directory.GetFiles(args[1].Substring(0, args[1].LastIndexOf("\\")), "*.jpg");
                    String[] getBmp = Directory.GetFiles(args[1].Substring(0, args[1].LastIndexOf("\\")), "*.bmp");
                    String[] getPng = Directory.GetFiles(args[1].Substring(0, args[1].LastIndexOf("\\")), "*.png");
                    String[] getGif = Directory.GetFiles(args[1].Substring(0, args[1].LastIndexOf("\\")), "*.gif");

                    IEnumerable<String> get = Directory.EnumerateFiles(args[1].Substring(0, args[1].LastIndexOf("\\")), "*.*", SearchOption.TopDirectoryOnly)
                        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".png") || s.EndsWith(".gif"));

                    get = CustomSort(get);
                    get.ToList().ForEach(x => Console.WriteLine(x));
                    String[] files = get.ToArray();

                    if (files.Length == 1)
                    {
                        file = files[0];
                        setImage();
                    } else
                    {
                        isMultiFile = true;
                        //Array.Sort(files, (x, y) => String.Compare(x, y));

                        for (int i = 0; i < files.Length; i++)
                        {
                            if (files[i].Contains(selected))
                            {
                                currentImage = i;
                                break;
                            }
                        }
                        
                        multFiles = files;
                        setImages();
                    }
                }
            }

        }

        private IEnumerable<string> CustomSort(IEnumerable<string> list)
        {
            int maxLen = list.Select(s => s.Length).Max();

            return list.Select(s => new
            {
                OrgStr = s,
                SortStr = Regex.Replace(s, @"(\d+)|(\D+)", m => m.Value.PadLeft(maxLen, char.IsDigit(m.Value[0]) ? ' ' : '\xffff'))
            })
            .OrderBy(x => x.SortStr)
            .Select(x => x.OrgStr);
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All images (*.jpg, *.bmp, *.png, *.gif)|*.jpg;*.bmp;*.png;*.gif| jpg (*.jpg)|*.jpg| bmp (*.bmp)|*.bmp| png (*.png)|*.png| gif (*.gif)|*.gif";
            ofd.Multiselect = false;

            if (ofd.ShowDialog().Equals(DialogResult.OK) && ofd.FileName.Length > 0)
            {
                isMultiFile = false;
                //rightButton.Visible = false;
                //leftButton.Visible = false;

                file = ofd.FileName;
                setImage();
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
                    isMultiFile = false;
                    //rightButton.Visible = false;
                    //leftButton.Visible = false;

                    file = ofd.FileName;
                    setImage();
                }
                else
                {
                    isMultiFile = true;
                    //rightButton.Visible = true;
                    //leftButton.Visible = true;

                    multFiles = ofd.FileNames;
                    setImages();
                }
            }
        }

        private void closeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Text = "ImageViewer";
            imageDisplayer.SizeMode = PictureBoxSizeMode.CenterImage;
            imageDisplayer.Image = global::ImageViewer.Properties.Resources.placeholder;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void setImage()
        {
            WindowState = FormWindowState.Maximized;
            Text = "ImageViewer - " + file;
            imageDisplayer.SizeMode = PictureBoxSizeMode.Zoom;
            imageDisplayer.Image = Image.FromFile(file);
        }

        private void setImages()
        {
            WindowState = FormWindowState.Maximized;
            Text = "ImageViewer - " + multFiles[currentImage];
            imageDisplayer.SizeMode = PictureBoxSizeMode.Zoom;
            imageDisplayer.Image = Image.FromFile(multFiles[currentImage]);
        }

        private void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    break;
                case Keys.S:
                    break;
                case Keys.A:
                    if (isMultiFile)
                    {
                        goLeft();
                    }
                    break;
                case Keys.D:
                    if (isMultiFile)
                    {
                        goRight();
                    }
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
                case Keys.Left:
                    if (isMultiFile)
                    {
                        goLeft();
                    }
                    break;
                case Keys.Right:
                    if (isMultiFile)
                    {
                        goRight();
                    }
                    break;
            }
        }

        private void goLeft()
        {
            if (isMultiFile)
            {
                if (currentImage == 0)
                {
                    currentImage = multFiles.Length - 1;
                }
                else
                {
                    currentImage--;
                }

                setImages();
            }
        }

        private void goRight()
        {
            if (isMultiFile)
            {
                if (currentImage == multFiles.Length - 1)
                {
                    currentImage = 0;
                }
                else
                {
                    currentImage++;
                }

                setImages();
            }
        }

        private void imageDisplayer_DoubleClick(object sender, EventArgs e)
        {
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
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable;
                menuStrip1.Visible = true;
                
                CenterToScreen();
                isFullscreen = false;
            }
        }
    }
}
