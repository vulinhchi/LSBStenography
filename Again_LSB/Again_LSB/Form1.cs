using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Again_LSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int ReverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }
        private void button1_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
            text_Mess.Text = "";
        }

        public static Bitmap Encode(String messa, Bitmap img)
        {
            int PixelIndex = 0;
            int Done = 0;// xét trạng thái có mã hóa tiếp hay không
            int msgIndex = 0;
            int charValueimg = 0;

            int count = 0;
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color pixel = img.GetPixel(j, i);//Get pixel at position(j,i)
                    R = pixel.R - pixel.R % 2;//set LSB của R thành bit chẵn
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;
                    for (int n = 0; n < 3; n++)
                    {
                        if (PixelIndex % 8 == 0)
                        {

                            if (Done == 1 && count == 8)
                            {

                                if ((PixelIndex - 1) % 3 < 2)
                                {
                                    img.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                
                            }
                            if (msgIndex >= messa.Length)
                            {
                                Done = 1;
                            }
                            else
                            {
                                charValueimg = messa[msgIndex++];
                            }
                        }
                        switch (PixelIndex % 3)
                        {
                            case 0:
                                {
                                    if (Done == 0)
                                    {

                                        R += charValueimg % 2;
                                        charValueimg /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (Done == 0)
                                    {
                                        G += charValueimg % 2;
                                         charValueimg /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (Done == 0)
                                    {
                                        B += charValueimg % 2;
                                            charValueimg /= 2;
                                    }

                                    img.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }
                        PixelIndex++;
                        if (Done == 1)
                        {

                            count++;
                        }
                    }
                }
            }
            return img;
        }
        private void Btn_Encode_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pictureBox1.Image;// lấy ảnh ra
            String messa = text_Mess.Text;// lấy dữ liệu trong ô text mess ra
            // kết quả
            Bitmap ketqua = Encode( messa, img);

            // lưu kết quả
            pictureBox1.Image = ketqua;
            SaveFileDialog saveFile = new SaveFileDialog();
            //save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";
            saveFile.Filter = "Image Files (*.png, *.bmp) | *.png; *.bmp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                switch (saveFile.FilterIndex)
                {
                    case 0:
                        {
                            img.Save(saveFile.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            img.Save(saveFile.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

            }
            text_Mess.Text = "";

        }

        public static String Decode(Bitmap img)
        {
            int PixelIndex = 0;
            int charValue = 0;
            string msg = "";
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color pixel = img.GetPixel(j, i);
                    for (int n = 0; n < 3; n++)
                    {
                        switch (PixelIndex % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        PixelIndex++;

                        if (PixelIndex % 8 == 0)
                        {

                            charValue = ReverseBits(charValue);
                            if (charValue == 0)
                               return msg;
                            char word = (char)charValue;
                            //msg += word.ToString();
                            msg += word;
                        }
                    }
                }
            }
            return msg;
        }

         
    

        private void Btn_Decode_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pictureBox1.Image;// lấy ảnh ra
              String ketqua = Decode(img);
                text_Mess.Text = ketqua;
        }

       
    }
}
