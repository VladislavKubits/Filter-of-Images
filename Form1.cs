using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Filtering_images
{
    public partial class Form1 : Form
    {

        private Bitmap bmp;
        private Bitmap newbmp;
        Filter[] filters = new Filter[11];
        int id = -1;

        private string filename;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBoxForDrawing.Width, pictureBoxForDrawing.Height);
            this.оброботатьToolStripMenuItem.Enabled = false;
            this.удалитьToolStripMenuItem.Enabled = false;
            this.выборФидьтраToolStripMenuItem.Enabled = false;

            using (StreamReader sr = File.OpenText(@"filters.txt"))
            {
                filters[0] = new Filter(); filters[0].Get_matrix(sr);
                filters[1] = new Filter(); filters[1].Get_matrix(sr);
                filters[2] = new Filter(); filters[2].Get_matrix(sr);
                filters[3] = new Filter(); filters[3].Get_matrix(sr);
                filters[4] = new Filter(); filters[4].Get_matrix(sr);
                filters[5] = new Filter(); filters[5].Get_matrix(sr);
                filters[6] = new Filter(); filters[6].Get_matrix(sr);
                filters[7] = new Filter(); filters[7].Get_matrix(sr);
                filters[8] = new Filter(); filters[8].Get_matrix(sr); filters[8].k = 1.0f / 9.0f;
                filters[9] = new Filter(); filters[9].Get_matrix(sr); filters[9].k = 1.0f / 16.0f;
                filters[10] = new Filter(); filters[10].Get_matrix(sr); filters[10].k = 0.1f;
            }
        }

        private void pictureBoxForDrawing_MouseMove(Object sender, MouseEventArgs e)
        {
            labelMouseMovePos.Text = "Положение курсора мыши: ";
            labelLeftMouseDownPosX.Text = "X = " + e.X;
            labelLeftMouseDownPosY.Text = "Y = " + (e.Y);

        }

        private void pictureBoxForDrawing_MouseLeave(Object sender, EventArgs e)
        {
            labelMouseMovePos.Text = " ";
            labelLeftMouseDownPosX.Text = " ";
            labelLeftMouseDownPosY.Text = " ";
        }

        private void оброботатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newbmp = new Bitmap(pictureBoxForDrawing.Width, pictureBoxForDrawing.Height);
            int x, y;
            labelMouseMovePos.Visible = false;
            labelLeftMouseDownPosX.Visible = false;
            labelLeftMouseDownPosY.Visible = false;
            progressBarForImage.Visible = true;
            progressBarForImage.Minimum = 0;
            progressBarForImage.Maximum = pictureBoxForDrawing.Width * pictureBoxForDrawing.Height;
            progressBarForImage.Value = 1;
            progressBarForImage.Step = 1;
            Bitmap bmpImage;
            Image jpg;
            try
            {
                jpg = Image.FromFile(filename);
                //Retrieve the image.
                bmpImage = new Bitmap(jpg, pictureBoxForDrawing.Width, pictureBoxForDrawing.Height);


                // Loop through the images pixels to reset color.
                for (x = 1; x < newbmp.Width - 1; x++)
                {
                    for (y = 1; y < newbmp.Height - 1; y++)
                    {
                        progressBarForImage.PerformStep();
                        double pixR = 0, pixG = 0, pixB = 0;
                        for (int i = x - 1, ii = 0; i <= x + 1; i++, ii++)
                            for (int j = y - 1, jj = 0; j <= y + 1; j++, jj++)
                            {

                                Color pc = bmpImage.GetPixel(i, j);
                                double R = pc.R, G = pc.G, B = pc.B;
                                R *= filters[id].matrix[ii, jj];
                                G *= filters[id].matrix[ii, jj];
                                B *= filters[id].matrix[ii, jj];
                                pixR += R; pixG += G; pixB += B;
                            }
                        pixR *= filters[id].k; pixG *= filters[id].k; pixB *= filters[id].k;
                        pixR = (pixR >= 0) ? pixR : Math.Abs(pixR);
                        pixG = (pixG >= 0) ? pixG : Math.Abs(pixG);
                        pixB = (pixB >= 0) ? pixB : Math.Abs(pixB);
                        pixR = (pixR <= 255) ? pixR : 255;
                        pixG = (pixG <= 255) ? pixG : 255;
                        pixB = (pixB <= 255) ? pixB : 255;
                        Color newColor = Color.FromArgb((int)pixR, (int)pixG, (int)pixB);
                        newbmp.SetPixel(x, y, newColor);
                        //progressBarForImage.PerformStep();
                    }
                    progressBarForImage.PerformStep();
                }

                // Set the PictureBox to display the image.
                pictureBoxForDrawing.Image = newbmp;
                progressBarForImage.Visible = false;
                labelMouseMovePos.Visible = true;
                labelLeftMouseDownPosX.Visible = true;
                labelLeftMouseDownPosY.Visible = true;
            }
            catch (ArgumentException)
            {
                progressBarForImage.Visible = false;
                labelMouseMovePos.Visible = true;
                labelLeftMouseDownPosX.Visible = true;
                labelLeftMouseDownPosY.Visible = true;
                MessageBox.Show("There was an error.", "Check the path to the image file.");
            }
            this.оброботатьToolStripMenuItem.Enabled = false;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxForDrawing.Width, pictureBoxForDrawing.Height);
            pictureBoxForDrawing.Image = bmp;
            this.удалитьToolStripMenuItem.Enabled = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 8;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            filename = openFileDialog1.FileName;
                            Image jpg = Image.FromFile(filename);
                            Bitmap bmpImage = new Bitmap(jpg, pictureBoxForDrawing.Width, pictureBoxForDrawing.Height);
                            pictureBoxForDrawing.Image = bmpImage;
                            bmp = bmpImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            this.выборФидьтраToolStripMenuItem.Enabled = true;
            this.удалитьToolStripMenuItem.Enabled = true;
        }

        private void северToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 0;
            label_filter.Text = "Ориентация \"север\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void северовостокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 1;
            label_filter.Text = "Ориентация \"северо-восток\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void востокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 2;
            label_filter.Text = "Ориентация \"восток\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void юговостокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 3;
            label_filter.Text = "Ориентация \"юго-восток\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void югToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 4;
            label_filter.Text = "Ориентация \"юг\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void югозападToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 5;
            label_filter.Text = "Ориентация \"юго-запад\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void западToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 6;
            label_filter.Text = "Ориентация \"запад\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void северозападToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 7;
            label_filter.Text = "Ориентация \"северо-запад\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void скользящееСреднееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 8;
            label_filter.Text = "\"Скользящее среднее\"";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void гаусовскийФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 9;
            label_filter.Text = "Гауссовский фильтр";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }

        private void весоваяФункцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxForDrawing.Image = bmp;
            id = 10;
            label_filter.Text = "Весовая функция";
            label_filter.ForeColor = Color.Green;
            this.оброботатьToolStripMenuItem.Enabled = true;
        }
    }
}
