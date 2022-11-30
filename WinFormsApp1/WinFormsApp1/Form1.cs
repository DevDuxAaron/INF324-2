using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        OpenFileDialog archivo = new OpenFileDialog();
        Bitmap bmp;
        Color [] colors = { new Color() , new Color(), new Color()}; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            archivo.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif";
            if (archivo.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
                bmp = new Bitmap(archivo.FileName);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            
            if (pixel1.Checked == true)
            {
                colors[0] = bmp.GetPixel(x, y);
                escribirRGB(0);
            }
            else if (pixel2.Checked == true)
            {
                colors[1] = bmp.GetPixel(x, y);
                escribirRGB(1);
            }
            else if (pixel3.Checked == true)
            {
                colors[2] = bmp.GetPixel(x, y);
                escribirRGB(2);
            }
        }
        private void escribirRGB(int n)
        {
            textBox1.Text = colors[n].R.ToString();
            textBox2.Text = colors[n].G.ToString();
            textBox3.Text = colors[n].B.ToString();
        }
        private Color obtenerMediaColor(int x, int y)
        {
            Color c = new Color();
            int mR = 0, mG = 0, mB = 0;
            for (int i = x; i < x + 10; i++)
            {
                for (int j = y; j < y + 10; j++)
                {
                    c = bmp.GetPixel(i,j);
                    mR += c.R;
                    mG += c.G;
                    mB += c.B;
                }
            }
            mR /= 100;
            mG /= 100;
            mB /= 100;
            return Color.FromArgb(mR, mG, mB);
        }

        private void pixel1_CheckedChanged(object sender, EventArgs e)
        {
            escribirRGB(0);
        }

        private void pixel2_CheckedChanged(object sender, EventArgs e)
        {
            escribirRGB(1);
        }

        private void pixel3_CheckedChanged(object sender, EventArgs e)
        {
            escribirRGB(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pintarColor(Color.Purple, 0);    
            pintarColor(Color.Fuchsia, 1);    
            pintarColor(Color.Blue, 2);    
        }
        private void pintarColor(Color nuevoColor, int pixel)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c;
            for (int i = 0; i < bmp.Width - 10; i += 10)
            {
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    c = obtenerMediaColor(i, j);
                    if ((c.R - 10 <= colors[pixel].R && colors[pixel].R <= c.R + 10) &&
                        (c.G - 10 <= colors[pixel].G && colors[pixel].G <= c.G + 10) &&
                        (c.B - 10 <= colors[pixel].B && colors[pixel].B <= c.B + 10))
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                bmp2.SetPixel(k, l, nuevoColor);
                            }
                        }
                    }
                    else
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                bmp2.SetPixel(k, l, bmp.GetPixel(k, l));
                            }
                        }
                    }
                }
            }
            bmp = bmp2;
            pictureBox1.Image = bmp2;
        }
    }
}