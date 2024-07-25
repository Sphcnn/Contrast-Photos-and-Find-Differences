using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arka_plan_silme_deneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void SelectPictureButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files| *.jpg; *.jpeg; *.png;";
            ofd.Title = "Bir resim dosyası seçiniz";
           
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string picturefile = ofd.FileName;
                SelectPicture_picturebox.Image = new Bitmap(ofd.FileName);
            }


           
            if (SelectPicture_picturebox.Image != null)
            {
                
                using (MemoryStream picturebyte = new MemoryStream())
                {
                    Bitmap picturebitmap = new Bitmap(SelectPicture_picturebox.Image);
                    picturebitmap.Save(picturebyte, ImageFormat.Bmp);
                    byte[] byteArray = picturebyte.ToArray();
                }
            }
        }

        private void SelectBackground_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files| *.jpg; *.jpeg; *.png;";
            ofd.Title = "Bir resim dosyası seçiniz";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string picturefile = ofd.FileName;
                SelectBackground_PictureBox.Image = new Bitmap(ofd.FileName);
            }

            if (SelectBackground_PictureBox.Image != null)
            {
                using (MemoryStream backgroundbyte = new MemoryStream())
                {
                    Bitmap backgroundbitmap = new Bitmap(SelectBackground_PictureBox.Image);
                    byte[] byteArray = backgroundbyte.ToArray();
                }
            }
        }

      
        private void ExtractButton_Click(object sender, EventArgs e)
        {
          
            if (SelectPicture_picturebox.Image != null && SelectBackground_PictureBox.Image != null)
            {
                Bitmap img1 = new Bitmap(SelectPicture_picturebox.Image);
                Bitmap img2 = new Bitmap(SelectBackground_PictureBox.Image);
                Bitmap resultImg = new Bitmap(img1.Width, img1.Height);

                int tolerans = (int)tolerans_numericUpDown1.Value;

                  
                // burada bitlerin belleklerini kitliyor ve doğrudan etkileşime geçiyor bu da hızlandırıyor
                    BitmapData img1Data = img1.LockBits(new Rectangle(0, 0, img1.Width, img1.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    BitmapData img2Data = img2.LockBits(new Rectangle(0, 0, img2.Width, img2.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    BitmapData resultData = resultImg.LockBits(new Rectangle(0, 0, resultImg.Width, resultImg.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);



                int bytesPerPixel = 3; // RGB formatında her piksel 3 byte
                int byteCount = img1Data.Stride * img1Data.Height;
                byte[] img1Pixels = new byte[byteCount];
                byte[] img2Pixels = new byte[byteCount];
                byte[] resultPixels = new byte[byteCount];

       
            
             
                
                
                
                
                System.Runtime.InteropServices.Marshal.Copy(img1Data.Scan0, img1Pixels, 0, byteCount);//burada pixel verileri kopyalanıyor
                System.Runtime.InteropServices.Marshal.Copy(img2Data.Scan0, img2Pixels, 0, byteCount);

             
                
                
                Parallel.For(0, img1Data.Height, y =>//bu her bir pixel için işlemi paralelleştiriyor ve hızlanmaya katkı sağlıyor
                {
                    int yOffset = y * img1Data.Stride;
                    for (int x = 0; x < img1Data.Width * bytesPerPixel; x += bytesPerPixel)
                    {
                        int rDiff = Math.Abs(img1Pixels[yOffset + x + 2] - img2Pixels[yOffset + x + 2]);
                        int gDiff = Math.Abs(img1Pixels[yOffset + x + 1] - img2Pixels[yOffset + x + 1]);
                        int bDiff = Math.Abs(img1Pixels[yOffset + x] - img2Pixels[yOffset + x]);

                        if (rDiff * 1.7 <= tolerans && gDiff * 1.7 <= tolerans && bDiff * 1.7 <= tolerans)
                        {
                            resultPixels[yOffset + x] = 0;
                            resultPixels[yOffset + x + 1] = 0;
                            resultPixels[yOffset + x + 2] = 0;
                        }
                        else
                        {
                            resultPixels[yOffset + x] = img1Pixels[yOffset + x];
                            resultPixels[yOffset + x + 1] = img1Pixels[yOffset + x + 1];
                            resultPixels[yOffset + x + 2] = img1Pixels[yOffset + x + 2];
                        }
                    }
                });

                System.Runtime.InteropServices.Marshal.Copy(resultPixels, 0, resultData.Scan0, byteCount);

                img1.UnlockBits(img1Data);//kitlenen bitmap bellekleri burada geri açlılıyor
                img2.UnlockBits(img2Data);
                resultImg.UnlockBits(resultData);

                Showresult_Picturebox.Image = resultImg;
                img1.Dispose();
                img2.Dispose();
           }
            else
            {
              MessageBox.Show("Lütfen iki resmi de yükleyin.");
            }
     }








        private void Showresult_Picturebox_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tolerans_numericUpDown1.Maximum = 250;
            tolerans_numericUpDown1.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
