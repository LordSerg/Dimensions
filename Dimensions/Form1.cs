using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimensions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        d2[] a2;
        d2[] h2;
        d3[] a3;
        d3[] h3;
        d4[] a4;
        d4[] h4;
        d5[] a5;
        d5[] h5;
        Bitmap b;
        Graphics g;
        int k = 2000;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2D");
            comboBox1.Items.Add("3D");
            comboBox1.Items.Add("4D");
            comboBox1.Items.Add("5D");
            a2 = new d2[4];
            h2 = new d2[k];
            a3 = new d3[8];
            h3 = new d3[k];
            a4 = new d4[16];
            h4 = new d4[k];
            a5 = new d5[32];
            h5 = new d5[k];
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Random r = new Random();
            d2.reset();
            d3.reset();
            d4.reset();
            d5.reset();
            int t = r.Next(0, 7);
            int size = 200;

            a2[0] = new d2(size, size);
            a2[1] = new d2(-size, size);
            a2[2] = new d2(-size, -size);
            a2[3] = new d2(size, -size);

            a3[0] = new d3(size, size, size);
            a3[1] = new d3(-size, size, size);
            a3[2] = new d3(-size, -size, size);
            a3[3] = new d3(size, -size, size);

            a3[4] = new d3(size, size, -size);
            a3[5] = new d3(-size, size, -size);
            a3[6] = new d3(-size, -size, -size);
            a3[7] = new d3(size, -size, -size);

            a4[0] = new d4(size, size, size, size);
            a4[1] = new d4(-size, size, size, size);
            a4[2] = new d4(-size, -size, size, size);
            a4[3] = new d4(size, -size, size, size);

            a4[4] = new d4(size, size, -size, size);
            a4[5] = new d4(-size, size, -size, size);
            a4[6] = new d4(-size, -size, -size, size);
            a4[7] = new d4(size, -size, -size, size);

            a4[8] = new d4(size, size, size, -size);
            a4[9] = new d4(-size, size, size, -size);
            a4[10] = new d4(-size, -size, size, -size);
            a4[11] = new d4(size, -size, size, -size);

            a4[12] = new d4(size, size, -size, -size);
            a4[13] = new d4(-size, size, -size, -size);
            a4[14] = new d4(-size, -size, -size, -size);
            a4[15] = new d4(size, -size, -size, -size);
            //.............................................
            a5[0] = new d5(size, size, size, size, size);
            a5[1] = new d5(-size, size, size, size, size);
            a5[2] = new d5(-size, -size, size, size, size);
            a5[3] = new d5(size, -size, size, size, size);

            a5[4] = new d5(size, size, -size, size, size);
            a5[5] = new d5(-size, size, -size, size, size);
            a5[6] = new d5(-size, -size, -size, size, size);
            a5[7] = new d5(size, -size, -size, size, size);

            a5[8] = new d5(size, size, size, -size, size);
            a5[9] = new d5(-size, size, size, -size, size);
            a5[10] = new d5(-size, -size, size, -size, size);
            a5[11] = new d5(size, -size, size, -size, size);

            a5[12] = new d5(size, size, -size, -size, size);
            a5[13] = new d5(-size, size, -size, -size, size);
            a5[14] = new d5(-size, -size, -size, -size, size);
            a5[15] = new d5(size, -size, -size, -size, size);

            a5[16] = new d5(size, size, size, size, -size);
            a5[17] = new d5(-size, size, size, size, -size);
            a5[18] = new d5(-size, -size, size, size, -size);
            a5[19] = new d5(size, -size, size, size, -size);

            a5[20] = new d5(size, size, -size, size, -size);
            a5[21] = new d5(-size, size, -size, size, -size);
            a5[22] = new d5(-size, -size, -size, size, -size);
            a5[23] = new d5(size, -size, -size, size, -size);

            a5[24] = new d5(size, size, size, -size, -size);
            a5[25] = new d5(-size, size, size, -size, -size);
            a5[26] = new d5(-size, -size, size, -size, -size);
            a5[27] = new d5(size, -size, size, -size, -size);

            a5[28] = new d5(size, size, -size, -size, -size);
            a5[29] = new d5(-size, size, -size, -size, -size);
            a5[30] = new d5(-size, -size, -size, -size, -size);
            a5[31] = new d5(size, -size, -size, -size, -size);

            for (int i = 0; i < k; i++)
            {//поверхности
                t = r.Next(0, 80);
                if (t == 0)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, size);//1
                else if (t == 1)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, -size);//1
                else if (t == 2)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, size);//1
                else if (t == 3)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, -size);//1
                else if (t == 4)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, size);//1
                else if (t == 5)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, -size);//1
                else if (t == 6)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, size);//1
                else if (t == 7)
                    h5[i] = new d5(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, -size);//1
                else if (t == 8)
                    h5[i] = new d5(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, size);//2
                else if (t == 9)
                    h5[i] = new d5(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, -size);//2
                else if (t == 10)
                    h5[i] = new d5(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, size);//2
                else if (t == 11)
                    h5[i] = new d5(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, -size);//2
                else if (t == 12)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, size);//2
                else if (t == 13)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, -size);//2
                else if (t == 14)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, size);//2
                else if (t == 15)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, -size);//2
                else if (t == 16)
                    h5[i] = new d5(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), size);//3
                else if (t == 17)
                    h5[i] = new d5(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), -size);//3
                else if (t == 18)
                    h5[i] = new d5(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), size);//3
                else if (t == 19)
                    h5[i] = new d5(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), -size);//3
                else if (t == 20)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), size);//3
                else if (t == 21)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), -size);//3
                else if (t == 22)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), size);//3
                else if (t == 23)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), -size);//3
                else if (t == 24)
                    h5[i] = new d5(r.Next(-size, size + 1), size, size, size, r.Next(-size, size + 1));//4
                else if (t == 25)
                    h5[i] = new d5(r.Next(-size, size + 1), size, size, -size, r.Next(-size, size + 1));//4
                else if (t == 26)
                    h5[i] = new d5(r.Next(-size, size + 1), size, -size, size, r.Next(-size, size + 1));//4
                else if (t == 27)
                    h5[i] = new d5(r.Next(-size, size + 1), size, -size, -size, r.Next(-size, size + 1));//4
                else if (t == 28)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, size, size, r.Next(-size, size + 1));//4
                else if (t == 29)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, size, -size, r.Next(-size, size + 1));//4
                else if (t == 30)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, -size, size, r.Next(-size, size + 1));//4
                else if (t == 31)
                    h5[i] = new d5(r.Next(-size, size + 1), -size, -size, -size, r.Next(-size, size + 1));//4
                else if (t == 32)
                    h5[i] = new d5(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);//5
                else if (t == 33)
                    h5[i] = new d5(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);//5
                else if (t == 34)
                    h5[i] = new d5(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);//5
                else if (t == 35)
                    h5[i] = new d5(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);//5
                else if (t == 36)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);//5
                else if (t == 37)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);//5
                else if (t == 38)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);//5
                else if (t == 39)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);//5
                else if (t == 40)
                    h5[i] = new d5(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);//6
                else if (t == 41)
                    h5[i] = new d5(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);//6
                else if (t == 42)
                    h5[i] = new d5(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);//6
                else if (t == 43)
                    h5[i] = new d5(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);//6
                else if (t == 44)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);//6
                else if (t == 45)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);//6
                else if (t == 46)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);//6
                else if (t == 47)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);//6
                else if (t == 48)
                    h5[i] = new d5(size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));//7
                else if (t == 49)
                    h5[i] = new d5(size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));//7
                else if (t == 50)
                    h5[i] = new d5(size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));//7
                else if (t == 51)
                    h5[i] = new d5(size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));//7
                else if (t == 52)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));//7
                else if (t == 53)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));//7
                else if (t == 54)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));//7
                else if (t == 55)
                    h5[i] = new d5(-size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));//7
                else if (t == 56)
                    h5[i] = new d5(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//8
                else if (t == 57)
                    h5[i] = new d5(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//8
                else if (t == 58)
                    h5[i] = new d5(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//8
                else if (t == 59)
                    h5[i] = new d5(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//8
                else if (t == 60)
                    h5[i] = new d5(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//8
                else if (t == 61)
                    h5[i] = new d5(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//8
                else if (t == 62)
                    h5[i] = new d5(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//8
                else if (t == 63)
                    h5[i] = new d5(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//8
                else if (t == 64)
                    h5[i] = new d5(size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//9
                else if (t == 65)
                    h5[i] = new d5(size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//9
                else if (t == 66)
                    h5[i] = new d5(size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//9
                else if (t == 67)
                    h5[i] = new d5(size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//9
                else if (t == 68)
                    h5[i] = new d5(-size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//9
                else if (t == 69)
                    h5[i] = new d5(-size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//9
                else if (t == 70)
                    h5[i] = new d5(-size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//9
                else if (t == 71)
                    h5[i] = new d5(-size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//9
                else if (t == 72)
                    h5[i] = new d5(size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 73)
                    h5[i] = new d5(size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 74)
                    h5[i] = new d5(size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 75)
                    h5[i] = new d5(size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 76)
                    h5[i] = new d5(-size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 77)
                    h5[i] = new d5(-size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 78)
                    h5[i] = new d5(-size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else
                    h5[i] = new d5(-size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//10

                t = r.Next(0, 24);
                if (t == 0)
                    h4[i] = new d4(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);
                else if (t == 1)
                    h4[i] = new d4(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);
                else if (t == 2)
                    h4[i] = new d4(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);
                else if (t == 3)
                    h4[i] = new d4(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);
                else if (t == 4)
                    h4[i] = new d4(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);
                else if (t == 5)
                    h4[i] = new d4(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);
                else if (t == 6)
                    h4[i] = new d4(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);
                else if (t == 7)
                    h4[i] = new d4(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);
                else if (t == 8)
                    h4[i] = new d4(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);
                else if (t == 9)
                    h4[i] = new d4(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);
                else if (t == 10)
                    h4[i] = new d4(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);
                else if (t == 11)
                    h4[i] = new d4(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);
                else if (t == 12)
                    h4[i] = new d4(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));
                else if (t == 13)
                    h4[i] = new d4(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));
                else if (t == 14)
                    h4[i] = new d4(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));
                else if (t == 15)
                    h4[i] = new d4(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));
                else if (t == 16)
                    h4[i] = new d4(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));
                else if (t == 17)
                    h4[i] = new d4(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));
                else if (t == 18)
                    h4[i] = new d4(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));
                else if (t == 19)
                    h4[i] = new d4(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));
                else if (t == 20)
                    h4[i] = new d4(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 21)
                    h4[i] = new d4(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else if (t == 22)
                    h4[i] = new d4(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else
                    h4[i] = new d4(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                t = r.Next(0, 6);
                if (t == 0)
                    h3[i] = new d3(r.Next(-size, size + 1), r.Next(-size, size + 1), size);
                else if (t == 1)
                    h3[i] = new d3(r.Next(-size, size + 1), r.Next(-size, size + 1), -size);
                else if (t == 2)
                    h3[i] = new d3(r.Next(-size, size + 1), size, r.Next(-size, size + 1));
                else if (t == 3)
                    h3[i] = new d3(r.Next(-size, size + 1), -size, r.Next(-size, size + 1));
                else if (t == 4)
                    h3[i] = new d3(size, r.Next(-size, size + 1), r.Next(-size, size + 1));
                else
                    h3[i] = new d3(-size, r.Next(-size, size + 1), r.Next(-size, size + 1));

                h2[i] = new d2(r.Next(-size, size + 1), r.Next(-size, size + 1));
            }
            g = Graphics.FromImage(b);
            //d4.reset();
            //d5.reset();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var l=new List<TrackBar>{trackBar1,trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar7, trackBar8, trackBar9, trackBar10 };

            foreach (TrackBar track in l)
            {
                track.Visible = false;
                track.Value = 0;
            }

            if (comboBox1.SelectedIndex==0)
            {//2d
                trackBar1.Visible = true;
            }
            else if(comboBox1.SelectedIndex==1)
            {//3d
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
            }
            else if(comboBox1.SelectedIndex==2)
            {//4d
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                trackBar4.Visible = true;
                trackBar5.Visible = true;
                trackBar6.Visible = true;
            }
            else
            {//5d
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                trackBar4.Visible = true;
                trackBar5.Visible = true;
                trackBar6.Visible = true;
                trackBar7.Visible = true;
                trackBar8.Visible = true;
                trackBar9.Visible = true;
                trackBar10.Visible = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            if(comboBox1.SelectedIndex==0)
            {//2d
                d2.reset();
                d2.rotate(trackBar1.Value);
                for (int i = 0; i < k; i++)
                {
                    d2.draw_point(h2[i], pictureBox1, g);
                }
                draw_square(a2);
                pictureBox1.Image = b;
                label1.Text = (!(d2.E1)).ToString();
                label2.Text = (!(d2.E2)).ToString();
            }
            else if(comboBox1.SelectedIndex==1)
            {//3d
                d3.reset();
                d3.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                for (int i = 0; i < k; i++)
                {
                    d3.draw_point(h3[i], pictureBox1, g);
                }
                draw_cube(a3);
                pictureBox1.Image = b;
                label1.Text = (!(d3.E1)).ToString();
                label2.Text = (!(d3.E2)).ToString();
                label3.Text = (!(d3.E3)).ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {//4d
                d4.reset();
                d4.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value, trackBar5.Value, trackBar6.Value);
                for (int i = 0; i < k; i++)
                {
                    d4.draw_point(h4[i], pictureBox1, g);
                }
                draw_tesseract(a4);
                pictureBox1.Image = b;
                label1.Text = (!(d4.E1)).ToString();
                label2.Text = (!(d4.E2)).ToString();
                label3.Text = (!(d4.E3)).ToString();
                label4.Text = (!(d4.E4)).ToString();
            }
            else if(comboBox1.SelectedIndex==3)
            {//5d
                d5.reset();
                d5.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value, trackBar5.Value, trackBar6.Value,trackBar7.Value, trackBar8.Value, trackBar9.Value, trackBar10.Value);
                for (int i = 0; i < k; i++)
                {
                    d5.draw_point(h5[i], pictureBox1, g);
                }
                draw_penteract(a5);
                pictureBox1.Image = b;
                label1.Text = (!(d5.E1)).ToString();
                label2.Text = (!(d5.E2)).ToString();
                label3.Text = (!(d5.E3)).ToString();
                label4.Text = (!(d5.E4)).ToString();
                label5.Text = (!(d5.E5)).ToString();
            }
        }
        void draw_penteract(d5[] r)
        {
            d5.draw_line(r[0],r[1],pictureBox1,g);
            d5.draw_line(r[0], r[3], pictureBox1, g);
            d5.draw_line(r[0], r[4], pictureBox1, g);
            d5.draw_line(r[0], r[8], pictureBox1, g);
            d5.draw_line(r[0], r[16], pictureBox1, g);

            d5.draw_line(r[1], r[2], pictureBox1, g);
            d5.draw_line(r[1], r[5], pictureBox1, g);
            d5.draw_line(r[1], r[9], pictureBox1, g);
            d5.draw_line(r[1], r[17], pictureBox1, g);

            d5.draw_line(r[2], r[3], pictureBox1, g);
            d5.draw_line(r[2], r[6], pictureBox1, g);
            d5.draw_line(r[2], r[10], pictureBox1, g);
            d5.draw_line(r[2], r[18], pictureBox1, g);

            d5.draw_line(r[3], r[7], pictureBox1, g);
            d5.draw_line(r[3], r[11], pictureBox1, g);
            d5.draw_line(r[3], r[19], pictureBox1, g);

            d5.draw_line(r[4], r[5], pictureBox1, g);
            d5.draw_line(r[4], r[7], pictureBox1, g);
            d5.draw_line(r[4], r[12], pictureBox1, g);
            d5.draw_line(r[4], r[20], pictureBox1, g);

            d5.draw_line(r[5], r[6], pictureBox1, g);
            d5.draw_line(r[5], r[13], pictureBox1, g);
            d5.draw_line(r[5], r[21], pictureBox1, g);

            d5.draw_line(r[6], r[7], pictureBox1, g);
            d5.draw_line(r[6], r[14], pictureBox1, g);
            d5.draw_line(r[6], r[22], pictureBox1, g);

            d5.draw_line(r[7], r[15], pictureBox1, g);
            d5.draw_line(r[7], r[23], pictureBox1, g);

            d5.draw_line(r[8], r[9], pictureBox1, g);
            d5.draw_line(r[8], r[11], pictureBox1, g);
            d5.draw_line(r[8], r[12], pictureBox1, g);
            d5.draw_line(r[8], r[24], pictureBox1, g);

            d5.draw_line(r[9], r[10], pictureBox1, g);
            d5.draw_line(r[9], r[13], pictureBox1, g);
            d5.draw_line(r[9], r[25], pictureBox1, g);

            d5.draw_line(r[10], r[11], pictureBox1, g);
            d5.draw_line(r[10], r[14], pictureBox1, g);
            d5.draw_line(r[10], r[26], pictureBox1, g);

            d5.draw_line(r[11], r[15], pictureBox1, g);
            d5.draw_line(r[11], r[27], pictureBox1, g);

            d5.draw_line(r[12], r[13], pictureBox1, g);
            d5.draw_line(r[12], r[15], pictureBox1, g);
            d5.draw_line(r[12], r[28], pictureBox1, g);

            d5.draw_line(r[13], r[14], pictureBox1, g);
            d5.draw_line(r[13], r[29], pictureBox1, g);

            d5.draw_line(r[14], r[15], pictureBox1, g);
            d5.draw_line(r[14], r[30], pictureBox1, g);

            d5.draw_line(r[15], r[31], pictureBox1, g);

            d5.draw_line(r[16], r[17], pictureBox1, g);
            d5.draw_line(r[16], r[19], pictureBox1, g);
            d5.draw_line(r[16], r[20], pictureBox1, g);
            d5.draw_line(r[16], r[24], pictureBox1, g);

            d5.draw_line(r[17], r[18], pictureBox1, g);
            d5.draw_line(r[17], r[21], pictureBox1, g);
            d5.draw_line(r[17], r[25], pictureBox1, g);

            d5.draw_line(r[18], r[19], pictureBox1, g);
            d5.draw_line(r[18], r[22], pictureBox1, g);
            d5.draw_line(r[18], r[26], pictureBox1, g);

            d5.draw_line(r[19], r[23], pictureBox1, g);
            d5.draw_line(r[19], r[27], pictureBox1, g);

            d5.draw_line(r[20], r[21], pictureBox1, g);
            d5.draw_line(r[20], r[23], pictureBox1, g);
            d5.draw_line(r[20], r[28], pictureBox1, g);

            d5.draw_line(r[21], r[22], pictureBox1, g);
            d5.draw_line(r[21], r[29], pictureBox1, g);

            d5.draw_line(r[22], r[23], pictureBox1, g);
            d5.draw_line(r[22], r[30], pictureBox1, g);

            d5.draw_line(r[23], r[31], pictureBox1, g);

            d5.draw_line(r[24], r[25], pictureBox1, g);
            d5.draw_line(r[24], r[27], pictureBox1, g);
            d5.draw_line(r[24], r[28], pictureBox1, g);

            d5.draw_line(r[25], r[26], pictureBox1, g);
            d5.draw_line(r[25], r[29], pictureBox1, g);

            d5.draw_line(r[26], r[27], pictureBox1, g);
            d5.draw_line(r[26], r[30], pictureBox1, g);

            d5.draw_line(r[27], r[31], pictureBox1, g);

            d5.draw_line(r[28], r[29], pictureBox1, g);
            d5.draw_line(r[28], r[31], pictureBox1, g);

            d5.draw_line(r[29], r[30], pictureBox1, g);

            d5.draw_line(r[30], r[31], pictureBox1, g);
        }
        void draw_tesseract(d4[] r)
        {
            d4.draw_line(r[0], r[1], pictureBox1, g);
            d4.draw_line(r[0], r[3], pictureBox1, g);
            d4.draw_line(r[0], r[4], pictureBox1, g);
            d4.draw_line(r[0], r[8], pictureBox1, g);

            d4.draw_line(r[1], r[9], pictureBox1, g);
            d4.draw_line(r[1], r[5], pictureBox1, g);
            d4.draw_line(r[1], r[2], pictureBox1, g);

            d4.draw_line(r[2], r[10], pictureBox1, g);
            d4.draw_line(r[2], r[6], pictureBox1, g);
            d4.draw_line(r[2], r[3], pictureBox1, g);

            d4.draw_line(r[3], r[11], pictureBox1, g);
            d4.draw_line(r[3], r[7], pictureBox1, g);

            d4.draw_line(r[4], r[12], pictureBox1, g);
            d4.draw_line(r[4], r[5], pictureBox1, g);
            d4.draw_line(r[4], r[7], pictureBox1, g);

            d4.draw_line(r[5], r[13], pictureBox1, g);
            d4.draw_line(r[5], r[6], pictureBox1, g);

            d4.draw_line(r[6], r[14], pictureBox1, g);
            d4.draw_line(r[6], r[7], pictureBox1, g);

            d4.draw_line(r[7], r[15], pictureBox1, g);

            d4.draw_line(r[8], r[9], pictureBox1, g);
            d4.draw_line(r[8], r[12], pictureBox1, g);
            d4.draw_line(r[8], r[11], pictureBox1, g);

            d4.draw_line(r[9], r[13], pictureBox1, g);
            d4.draw_line(r[9], r[10], pictureBox1, g);

            d4.draw_line(r[10], r[11], pictureBox1, g);
            d4.draw_line(r[10], r[14], pictureBox1, g);

            d4.draw_line(r[11], r[15], pictureBox1, g);

            d4.draw_line(r[12], r[13], pictureBox1, g);
            d4.draw_line(r[12], r[15], pictureBox1, g);

            d4.draw_line(r[13], r[14], pictureBox1, g);

            d4.draw_line(r[14], r[15], pictureBox1, g);
        }
        void draw_cube(d3[]r)
        {
            d3.draw_line(r[0], r[1], pictureBox1, g);
            d3.draw_line(r[0], r[3], pictureBox1, g);
            d3.draw_line(r[0], r[4], pictureBox1, g);

            d3.draw_line(r[1], r[2], pictureBox1, g);
            d3.draw_line(r[1], r[5], pictureBox1, g);

            d3.draw_line(r[2], r[3], pictureBox1, g);
            d3.draw_line(r[2], r[6], pictureBox1, g);

            d3.draw_line(r[3], r[7], pictureBox1, g);

            d3.draw_line(r[4], r[5], pictureBox1, g);
            d3.draw_line(r[4], r[7], pictureBox1, g);

            d3.draw_line(r[5], r[6], pictureBox1, g);

            d3.draw_line(r[6], r[7], pictureBox1, g);
        }
        void draw_square(d2[]r)
        {
            d2.draw_line(r[0], r[1], pictureBox1, g);
            d2.draw_line(r[0], r[3], pictureBox1, g);
            d2.draw_line(r[1], r[2], pictureBox1, g);
            d2.draw_line(r[2], r[3], pictureBox1, g);
        }
        private void PictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Width > 0 && pictureBox1.Height > 0)
                b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
        }
    }
}
