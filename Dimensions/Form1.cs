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
        d6[] a6;
        d6[] h6;
        Bitmap b;
        Graphics g;
        int k = 3000;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2D");
            comboBox1.Items.Add("3D");
            comboBox1.Items.Add("4D");
            comboBox1.Items.Add("5D");
            comboBox1.Items.Add("6D");
            a2 = new d2[4];
            h2 = new d2[k];
            a3 = new d3[8];
            h3 = new d3[k];
            a4 = new d4[16];
            h4 = new d4[k];
            a5 = new d5[32];
            h5 = new d5[k];
            a6 = new d6[64];
            h6 = new d6[k];
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Random r = new Random();
            d2.reset();
            d3.reset();
            d4.reset();
            d5.reset();
            d6.reset();
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
            //.............................................
            a6[0] = new d6(size, size, size, size, size, size);
            a6[1] = new d6(-size, size, size, size, size, size);
            a6[2] = new d6(-size, -size, size, size, size, size);
            a6[3] = new d6(size, -size, size, size, size, size);

            a6[4] = new d6(size, size, -size, size, size, size);
            a6[5] = new d6(-size, size, -size, size, size, size);
            a6[6] = new d6(-size, -size, -size, size, size, size);
            a6[7] = new d6(size, -size, -size, size, size, size);

            a6[8] = new d6(size, size, size, -size, size, size);
            a6[9] = new d6(-size, size, size, -size, size, size);
            a6[10] = new d6(-size, -size, size, -size, size, size);
            a6[11] = new d6(size, -size, size, -size, size, size);

            a6[12] = new d6(size, size, -size, -size, size, size);
            a6[13] = new d6(-size, size, -size, -size, size, size);
            a6[14] = new d6(-size, -size, -size, -size, size, size);
            a6[15] = new d6(size, -size, -size, -size, size, size);

            a6[16] = new d6(size, size, size, size, -size, size);
            a6[17] = new d6(-size, size, size, size, -size, size);
            a6[18] = new d6(-size, -size, size, size, -size, size);
            a6[19] = new d6(size, -size, size, size, -size, size);

            a6[20] = new d6(size, size, -size, size, -size, size);
            a6[21] = new d6(-size, size, -size, size, -size, size);
            a6[22] = new d6(-size, -size, -size, size, -size, size);
            a6[23] = new d6(size, -size, -size, size, -size, size);

            a6[24] = new d6(size, size, size, -size, -size, size);
            a6[25] = new d6(-size, size, size, -size, -size, size);
            a6[26] = new d6(-size, -size, size, -size, -size, size);
            a6[27] = new d6(size, -size, size, -size, -size, size);

            a6[28] = new d6(size, size, -size, -size, -size, size);
            a6[29] = new d6(-size, size, -size, -size, -size, size);
            a6[30] = new d6(-size, -size, -size, -size, -size, size);
            a6[31] = new d6(size, -size, -size, -size, -size, size);

            a6[32] = new d6(size, size, size, size, size, -size);
            a6[33] = new d6(-size, size, size, size, size, -size);
            a6[34] = new d6(-size, -size, size, size, size, -size);
            a6[35] = new d6(size, -size, size, size, size, -size);

            a6[36] = new d6(size, size, -size, size, size, -size);
            a6[37] = new d6(-size, size, -size, size, size, -size);
            a6[38] = new d6(-size, -size, -size, size, size, -size);
            a6[39] = new d6(size, -size, -size, size, size, -size);

            a6[40] = new d6(size, size, size, -size, size, -size);
            a6[41] = new d6(-size, size, size, -size, size, -size);
            a6[42] = new d6(-size, -size, size, -size, size, -size);
            a6[43] = new d6(size, -size, size, -size, size, -size);

            a6[44] = new d6(size, size, -size, -size, size, -size);
            a6[45] = new d6(-size, size, -size, -size, size, -size);
            a6[46] = new d6(-size, -size, -size, -size, size, -size);
            a6[47] = new d6(size, -size, -size, -size, size, -size);

            a6[48] = new d6(size, size, size, size, -size, -size);
            a6[49] = new d6(-size, size, size, size, -size, -size);
            a6[50] = new d6(-size, -size, size, size, -size, -size);
            a6[51] = new d6(size, -size, size, size, -size, -size);

            a6[52] = new d6(size, size, -size, size, -size, -size);
            a6[53] = new d6(-size, size, -size, size, -size, -size);
            a6[54] = new d6(-size, -size, -size, size, -size, -size);
            a6[55] = new d6(size, -size, -size, size, -size, -size);

            a6[56] = new d6(size, size, size, -size, -size, -size);
            a6[57] = new d6(-size, size, size, -size, -size, -size);
            a6[58] = new d6(-size, -size, size, -size, -size, -size);
            a6[59] = new d6(size, -size, size, -size, -size, -size);

            a6[60] = new d6(size, size, -size, -size, -size, -size);
            a6[61] = new d6(-size, size, -size, -size, -size, -size);
            a6[62] = new d6(-size, -size, -size, -size, -size, -size);
            a6[63] = new d6(size, -size, -size, -size, -size, -size);

            

            for (int i = 0; i < k; i++)
            {//поверхности
                t = r.Next(0, 240);
                if (t == 0)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, size, size);//1
                else if (t == 1)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, size, -size);//1
                else if (t == 2)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, -size, size);//1
                else if (t == 3)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, -size, -size);//1
                else if (t == 4)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, size, size);//1
                else if (t == 5)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, size, -size);//1
                else if (t == 6)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, -size, size);//1
                else if (t == 7)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, -size, -size);//1
                else if (t == 8)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, size, size);//1
                else if (t == 9)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, size, -size);//1
                else if (t == 10)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, -size, size);//1
                else if (t == 11)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, -size, -size);//1
                else if (t == 12)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, size, size);//1
                else if (t == 13)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, size, -size);//1
                else if (t == 14)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, -size, size);//1
                else if (t == 15)
                    h6[i] = new d6(r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, -size, -size);//1

                else if (t == 16)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, size, size);//2
                else if (t == 17)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, size, -size);//2
                else if (t == 18)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, -size, size);//2
                else if (t == 19)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, -size, -size);//2
                else if (t == 20)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, size, size);//2
                else if (t == 21)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, size, -size);//2
                else if (t == 22)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, -size, size);//2
                else if (t == 23)
                    h6[i] = new d6(r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, -size, -size);//2
                else if (t == 24)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, size, size);//2
                else if (t == 25)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, size, -size);//2
                else if (t == 26)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, -size, size);//2
                else if (t == 27)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, -size, -size);//2
                else if (t == 28)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, size, size);//2
                else if (t == 29)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, size, -size);//2
                else if (t == 30)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, -size, size);//2
                else if (t == 31)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, -size, -size);//2

                else if (t == 32)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), size, size);//3
                else if (t == 33)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), size, -size);//3
                else if (t == 34)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), -size, size);//3
                else if (t == 35)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), -size, -size);//3
                else if (t == 36)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), size, size);//3
                else if (t == 37)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), size, -size);//3
                else if (t == 38)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), -size, size);//3
                else if (t == 39)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), -size, -size);//3
                else if (t == 40)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), size, size);//3
                else if (t == 41)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), size, -size);//3
                else if (t == 42)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), -size, size);//3
                else if (t == 43)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), -size, -size);//3
                else if (t == 44)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), size, size);//3
                else if (t == 45)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), size, -size);//3
                else if (t == 46)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), -size, size);//3
                else if (t == 47)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), -size, -size);//3

                else if (t == 48)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, size, r.Next(-size, size + 1), size);//4
                else if (t == 49)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, size, r.Next(-size, size + 1), -size);//4
                else if (t == 50)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, -size, r.Next(-size, size + 1), size);//4
                else if (t == 51)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, -size, r.Next(-size, size + 1), -size);//4
                else if (t == 52)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, size, r.Next(-size, size + 1), size);//4
                else if (t == 53)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, size, r.Next(-size, size + 1), -size);//4
                else if (t == 54)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, -size, r.Next(-size, size + 1), size);//4
                else if (t == 55)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, -size, r.Next(-size, size + 1), -size);//4
                else if (t == 56)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, size, r.Next(-size, size + 1), size);//4
                else if (t == 57)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, size, r.Next(-size, size + 1), -size);//4
                else if (t == 58)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, -size, r.Next(-size, size + 1), size);//4
                else if (t == 59)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, -size, r.Next(-size, size + 1), -size);//4
                else if (t == 60)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, size, r.Next(-size, size + 1), size);//4
                else if (t == 61)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, size, r.Next(-size, size + 1), -size);//4
                else if (t == 62)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, -size, r.Next(-size, size + 1), size);//4
                else if (t == 63)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, -size, r.Next(-size, size + 1), -size);//4

                else if (t == 64)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, size, size, r.Next(-size, size + 1));//5
                else if (t == 65)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, size, -size, r.Next(-size, size + 1));//5
                else if (t == 66)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, -size, size, r.Next(-size, size + 1));//5
                else if (t == 67)
                    h6[i] = new d6(r.Next(-size, size + 1), size, size, -size, -size, r.Next(-size, size + 1));//5
                else if (t == 68)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, size, size, r.Next(-size, size + 1));//5
                else if (t == 69)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, size, -size, r.Next(-size, size + 1));//5
                else if (t == 70)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, -size, size, r.Next(-size, size + 1));//5
                else if (t == 71)
                    h6[i] = new d6(r.Next(-size, size + 1), size, -size, -size, -size, r.Next(-size, size + 1));//5
                else if (t == 72)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, size, size, r.Next(-size, size + 1));//5
                else if (t == 73)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, size, -size, r.Next(-size, size + 1));//5
                else if (t == 74)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, -size, size, r.Next(-size, size + 1));//5
                else if (t == 75)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, size, -size, -size, r.Next(-size, size + 1));//5
                else if (t == 76)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, size, size, r.Next(-size, size + 1));//5
                else if (t == 77)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, size, -size, r.Next(-size, size + 1));//5
                else if (t == 78)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, -size, size, r.Next(-size, size + 1));//5
                else if (t == 79)
                    h6[i] = new d6(r.Next(-size, size + 1), -size, -size, -size, -size, r.Next(-size, size + 1));//5

                else if (t == 80)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, size);//6
                else if (t == 81)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, -size);//6
                else if (t == 82)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, size);//6
                else if (t == 83)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, -size);//6
                else if (t == 84)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, size);//6
                else if (t == 85)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, -size);//6
                else if (t == 86)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, size);//6
                else if (t == 87)
                    h6[i] = new d6(size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, -size);//6
                else if (t == 88)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, size);//6
                else if (t == 89)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size, -size);//6
                else if (t == 90)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, size);//6
                else if (t == 91)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size, -size);//6
                else if (t == 92)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, size);//6
                else if (t == 93)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size, -size);//6
                else if (t == 94)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, size);//6
                else if (t == 95)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size, -size);//6

                else if (t == 96)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, size);//7
                else if (t == 97)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, -size);//7
                else if (t == 98)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, size);//7
                else if (t == 99)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, -size);//7
                else if (t == 100)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, size);//7
                else if (t == 101)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, -size);//7
                else if (t == 102)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, size);//7
                else if (t == 103)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, -size);//7
                else if (t == 104)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, size);//7
                else if (t == 105)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size, -size);//7
                else if (t == 106)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, size);//7
                else if (t == 107)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size, -size);//7
                else if (t == 108)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, size);//7
                else if (t == 109)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size, -size);//7
                else if (t == 110)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, size);//7
                else if (t == 111)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size, -size);//7

                else if (t == 112)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), size);//8
                else if (t == 113)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), -size);//8
                else if (t == 114)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), size);//8
                else if (t == 115)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), -size);//8
                else if (t == 116)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), size);//8
                else if (t == 117)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), -size);//8
                else if (t == 118)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), size);//8
                else if (t == 119)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), -size);//8
                else if (t == 120)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), size);//8
                else if (t == 121)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1), -size);//8
                else if (t == 122)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), size);//8
                else if (t == 123)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1), -size);//8
                else if (t == 124)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), size);//8
                else if (t == 125)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1), -size);//8
                else if (t == 126)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), size);//8
                else if (t == 127)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1), -size);//8

                else if (t == 128)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, size, size, r.Next(-size, size + 1));//9
                else if (t == 129)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, size, -size, r.Next(-size, size + 1));//9
                else if (t == 130)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, -size, size, r.Next(-size, size + 1));//9
                else if (t == 131)
                    h6[i] = new d6(size, r.Next(-size, size + 1), size, -size, -size, r.Next(-size, size + 1));//9
                else if (t == 132)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, size, size, r.Next(-size, size + 1));//9
                else if (t == 133)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, size, -size, r.Next(-size, size + 1));//9
                else if (t == 134)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, -size, size, r.Next(-size, size + 1));//9
                else if (t == 135)
                    h6[i] = new d6(size, r.Next(-size, size + 1), -size, -size, -size, r.Next(-size, size + 1));//9
                else if (t == 136)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, size, size, r.Next(-size, size + 1));//9
                else if (t == 137)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, size, -size, r.Next(-size, size + 1));//9
                else if (t == 138)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, -size, size, r.Next(-size, size + 1));//9
                else if (t == 139)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), size, -size, -size, r.Next(-size, size + 1));//9
                else if (t == 140)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, size, size, r.Next(-size, size + 1));//9
                else if (t == 141)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, size, -size, r.Next(-size, size + 1));//9
                else if (t == 142)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, -size, size, r.Next(-size, size + 1));//9
                else if (t == 143)
                    h6[i] = new d6(-size, r.Next(-size, size + 1), -size, -size, -size, r.Next(-size, size + 1));//9

                else if (t == 144)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);//10
                else if (t == 145)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);//10
                else if (t == 146)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);//10
                else if (t == 147)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);//10
                else if (t == 148)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);//10
                else if (t == 149)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);//10
                else if (t == 150)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);//10
                else if (t == 151)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);//10
                else if (t == 152)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);//10
                else if (t == 153)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);//10
                else if (t == 154)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);//10
                else if (t == 155)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);//10
                else if (t == 156)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, size);//10
                else if (t == 157)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size, -size);//10
                else if (t == 158)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, size);//10
                else if (t == 159)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size, -size);//10

                else if (t == 160)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);//11
                else if (t == 161)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);//11
                else if (t == 162)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);//11
                else if (t == 163)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);//11
                else if (t == 164)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);//11
                else if (t == 165)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);//11
                else if (t == 166)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);//11
                else if (t == 167)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);//11
                else if (t == 168)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);//11
                else if (t == 169)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);//11
                else if (t == 170)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);//11
                else if (t == 171)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);//11
                else if (t == 172)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), size);//11
                else if (t == 173)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1), -size);//11
                else if (t == 174)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), size);//11
                else if (t == 175)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1), -size);//11

                else if (t == 176)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));//12
                else if (t == 177)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));//12
                else if (t == 178)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));//12
                else if (t == 179)
                    h6[i] = new d6(size, size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));//12
                else if (t == 180)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));//12
                else if (t == 181)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));//12
                else if (t == 182)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));//12
                else if (t == 183)
                    h6[i] = new d6(size, -size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));//12
                else if (t == 184)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));//12
                else if (t == 185)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));//12
                else if (t == 186)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));//12
                else if (t == 187)
                    h6[i] = new d6(-size, size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));//12
                else if (t == 188)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), size, size, r.Next(-size, size + 1));//12
                else if (t == 189)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), size, -size, r.Next(-size, size + 1));//12
                else if (t == 190)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), -size, size, r.Next(-size, size + 1));//12
                else if (t == 191)
                    h6[i] = new d6(-size, -size, r.Next(-size, size + 1), -size, -size, r.Next(-size, size + 1));//12

                else if (t == 192)
                    h6[i] = new d6(size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 193)
                    h6[i] = new d6(size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 194)
                    h6[i] = new d6(size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 195)
                    h6[i] = new d6(size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 196)
                    h6[i] = new d6(size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 197)
                    h6[i] = new d6(size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 198)
                    h6[i] = new d6(size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 199)
                    h6[i] = new d6(size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 200)
                    h6[i] = new d6(-size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 201)
                    h6[i] = new d6(-size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 202)
                    h6[i] = new d6(-size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 203)
                    h6[i] = new d6(-size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 204)
                    h6[i] = new d6(-size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 205)
                    h6[i] = new d6(-size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13
                else if (t == 206)
                    h6[i] = new d6(-size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), size);//13
                else if (t == 207)
                    h6[i] = new d6(-size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1), -size);//13

                else if (t == 208)
                    h6[i] = new d6(size, size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 209)
                    h6[i] = new d6(size, size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 210)
                    h6[i] = new d6(size, size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 211)
                    h6[i] = new d6(size, size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 212)
                    h6[i] = new d6(size, -size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 213)
                    h6[i] = new d6(size, -size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 214)
                    h6[i] = new d6(size, -size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 215)
                    h6[i] = new d6(size, -size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 216)
                    h6[i] = new d6(-size, size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 217)
                    h6[i] = new d6(-size, size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 218)
                    h6[i] = new d6(-size, size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 219)
                    h6[i] = new d6(-size, size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 220)
                    h6[i] = new d6(-size, -size, size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 221)
                    h6[i] = new d6(-size, -size, size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14
                else if (t == 222)
                    h6[i] = new d6(-size, -size, -size, r.Next(-size, size + 1), size, r.Next(-size, size + 1));//14
                else if (t == 223)
                    h6[i] = new d6(-size, -size, -size, r.Next(-size, size + 1), -size, r.Next(-size, size + 1));//14

                else if (t == 224)
                    h6[i] = new d6(size, size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 225)
                    h6[i] = new d6(size, size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 226)
                    h6[i] = new d6(size, size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 227)
                    h6[i] = new d6(size, size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 228)
                    h6[i] = new d6(size, -size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 229)
                    h6[i] = new d6(size, -size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 230)
                    h6[i] = new d6(size, -size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 231)
                    h6[i] = new d6(size, -size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 232)
                    h6[i] = new d6(-size, size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 233)
                    h6[i] = new d6(-size, size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 234)
                    h6[i] = new d6(-size, size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 235)
                    h6[i] = new d6(-size, size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 236)
                    h6[i] = new d6(-size, -size, size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 237)
                    h6[i] = new d6(-size, -size, size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else if (t == 238)
                    h6[i] = new d6(-size, -size, -size, size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15
                else
                    h6[i] = new d6(-size, -size, -size, -size, r.Next(-size, size + 1), r.Next(-size, size + 1));//15

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
            var l=new List<TrackBar>{trackBar1,trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar7, trackBar8, trackBar9, trackBar10
            , trackBar11,trackBar12, trackBar13, trackBar14, trackBar15, trackBar16, trackBar17, trackBar18, trackBar19, trackBar20, trackBar21};

            foreach (TrackBar track in l)
            {
                track.Visible = false;
                track.Value = 0;
            }

            if (comboBox1.SelectedIndex == 0)
            {//2d
                trackBar1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {//3d
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {//4d
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                trackBar4.Visible = true;
                trackBar5.Visible = true;
                trackBar6.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 3)
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
            else
            {//6d
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
                trackBar11.Visible = true;
                trackBar12.Visible = true;
                trackBar13.Visible = true;
                trackBar14.Visible = true;
                trackBar15.Visible = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.FromArgb(255, 180, 180, 180));
            if(comboBox1.SelectedIndex==0)
            {//2d
                //d2.reset();
                d2.rotate(trackBar1.Value);
                for (int i = 0; i < k; i++)
                {
                    d2.draw_point(h2[i], pictureBox1, g);
                }
                draw_square(a2);
                d2.draw_basis(pictureBox1, g);
                pictureBox1.Image = b;
                label1.Text = (!(d2.E1)).ToString();
                label2.Text = (!(d2.E2)).ToString();
            }
            else if(comboBox1.SelectedIndex==1)
            {//3d
                //d3.reset();
                d3.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                for (int i = 0; i < k; i++)
                {
                    d3.draw_point(h3[i], pictureBox1, g);
                }
                draw_cube(a3);
                d3.draw_basis(pictureBox1,g);
                label1.Text = (!(d3.E1)).ToString();
                label2.Text = (!(d3.E2)).ToString();
                label3.Text = (!(d3.E3)).ToString();
                pictureBox1.Image = b;
            }
            else if (comboBox1.SelectedIndex == 2)
            {//4d
                //d4.reset();
                d4.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value, trackBar5.Value, trackBar6.Value);
                for (int i = 0; i < k; i++)
                {
                    d4.draw_point(h4[i], pictureBox1, g);
                }
                draw_tesseract(a4);
                d4.draw_basis(pictureBox1, g);
                pictureBox1.Image = b;
                label1.Text = (!(d4.E1)).ToString();
                label2.Text = (!(d4.E2)).ToString();
                label3.Text = (!(d4.E3)).ToString();
                label4.Text = (!(d4.E4)).ToString();
            }
            else if(comboBox1.SelectedIndex==3)
            {//5d
                //d5.reset();
                d5.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value, trackBar5.Value, trackBar6.Value,trackBar7.Value, trackBar8.Value, trackBar9.Value, trackBar10.Value);
                for (int i = 0; i < k; i++)
                {
                    d5.draw_point(h5[i], pictureBox1, g);
                }
                draw_penteract(a5);
                d5.draw_basis(pictureBox1, g);
                pictureBox1.Image = b;
                label1.Text = (!(d5.E1)).ToString();
                label2.Text = (!(d5.E2)).ToString();
                label3.Text = (!(d5.E3)).ToString();
                label4.Text = (!(d5.E4)).ToString();
                label5.Text = (!(d5.E5)).ToString();
            }
            else if(comboBox1.SelectedIndex==4)
            {
                d6.rotate(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value, trackBar5.Value, trackBar6.Value, trackBar7.Value, trackBar8.Value, trackBar9.Value, trackBar10.Value, trackBar11.Value, trackBar12.Value, trackBar13.Value, trackBar14.Value, trackBar15.Value);
                //for (int i = 0; i < 64; i++)
                //{
                //    d6.draw_point(a6[i], pictureBox1, g);
                //}
                draw_hexeract(a6);
                for (int i = 0; i < k; i++)
                {
                    d6.draw_point_col(h6[i], pictureBox1, g, Color.Black);
                }
                d6.draw_basis(pictureBox1, g);
                pictureBox1.Image = b;
            }
        }
        void draw_basis3d()
        {
            d3 x = new d3(100, 0, 0);
            d3 y = new d3(0, 100, 0);
            d3 z = new d3(0, 0, 100);
            d3 zero = new d3(0, 0, 0);
            d3.draw_line(zero, x, pictureBox1, g);
            d3.draw_line(zero, y, pictureBox1, g);
            d3.draw_line(zero, z, pictureBox1, g);
        }
        void draw_hexeract(d6[] r)
        {
            //for (int i = 0; i < r.Length; i++)
            //    for (int j = i + 1; j < r.Length; j++)
            //        d6.draw_line(r[i], r[j], pictureBox1, g);
            d6.draw_line(r[0], r[1], pictureBox1, g);
            d6.draw_line(r[0], r[3], pictureBox1, g);
            d6.draw_line(r[0], r[4], pictureBox1, g);
            d6.draw_line(r[0], r[8], pictureBox1, g);
            d6.draw_line(r[0], r[16], pictureBox1, g);
            d6.draw_line(r[0], r[32], pictureBox1, g);

            d6.draw_line(r[1], r[2], pictureBox1, g);
            d6.draw_line(r[1], r[5], pictureBox1, g);
            d6.draw_line(r[1], r[9], pictureBox1, g);
            d6.draw_line(r[1], r[17], pictureBox1, g);
            d6.draw_line(r[1], r[33], pictureBox1, g);

            d6.draw_line(r[2], r[3], pictureBox1, g);
            d6.draw_line(r[2], r[6], pictureBox1, g);
            d6.draw_line(r[2], r[10], pictureBox1, g);
            d6.draw_line(r[2], r[18], pictureBox1, g);
            d6.draw_line(r[2], r[34], pictureBox1, g);

            d6.draw_line(r[3], r[7], pictureBox1, g);
            d6.draw_line(r[3], r[11], pictureBox1, g);
            d6.draw_line(r[3], r[19], pictureBox1, g);
            d6.draw_line(r[3], r[35], pictureBox1, g);

            d6.draw_line(r[4], r[5], pictureBox1, g);
            d6.draw_line(r[4], r[7], pictureBox1, g);
            d6.draw_line(r[4], r[12], pictureBox1, g);
            d6.draw_line(r[4], r[20], pictureBox1, g);
            d6.draw_line(r[4], r[36], pictureBox1, g);

            d6.draw_line(r[5], r[6], pictureBox1, g);
            d6.draw_line(r[5], r[13], pictureBox1, g);
            d6.draw_line(r[5], r[21], pictureBox1, g);
            d6.draw_line(r[5], r[37], pictureBox1, g);

            d6.draw_line(r[6], r[7], pictureBox1, g);
            d6.draw_line(r[6], r[14], pictureBox1, g);
            d6.draw_line(r[6], r[22], pictureBox1, g);
            d6.draw_line(r[6], r[38], pictureBox1, g);

            d6.draw_line(r[7], r[15], pictureBox1, g);
            d6.draw_line(r[7], r[23], pictureBox1, g);
            d6.draw_line(r[7], r[39], pictureBox1, g);

            d6.draw_line(r[8], r[9], pictureBox1, g);
            d6.draw_line(r[8], r[11], pictureBox1, g);
            d6.draw_line(r[8], r[12], pictureBox1, g);
            d6.draw_line(r[8], r[24], pictureBox1, g);
            d6.draw_line(r[8], r[40], pictureBox1, g);

            d6.draw_line(r[9], r[10], pictureBox1, g);
            d6.draw_line(r[9], r[13], pictureBox1, g);
            d6.draw_line(r[9], r[25], pictureBox1, g);
            d6.draw_line(r[9], r[41], pictureBox1, g);

            d6.draw_line(r[10], r[11], pictureBox1, g);
            d6.draw_line(r[10], r[14], pictureBox1, g);
            d6.draw_line(r[10], r[26], pictureBox1, g);
            d6.draw_line(r[10], r[42], pictureBox1, g);

            d6.draw_line(r[11], r[15], pictureBox1, g);
            d6.draw_line(r[11], r[27], pictureBox1, g);
            d6.draw_line(r[11], r[43], pictureBox1, g);

            d6.draw_line(r[12], r[13], pictureBox1, g);
            d6.draw_line(r[12], r[15], pictureBox1, g);
            d6.draw_line(r[12], r[28], pictureBox1, g);
            d6.draw_line(r[12], r[44], pictureBox1, g);

            d6.draw_line(r[13], r[14], pictureBox1, g);
            d6.draw_line(r[13], r[29], pictureBox1, g);
            d6.draw_line(r[13], r[45], pictureBox1, g);

            d6.draw_line(r[14], r[15], pictureBox1, g);
            d6.draw_line(r[14], r[30], pictureBox1, g);
            d6.draw_line(r[14], r[46], pictureBox1, g);

            d6.draw_line(r[15], r[31], pictureBox1, g);
            d6.draw_line(r[15], r[47], pictureBox1, g);

            d6.draw_line(r[16], r[17], pictureBox1, g);
            d6.draw_line(r[16], r[19], pictureBox1, g);
            d6.draw_line(r[16], r[20], pictureBox1, g);
            d6.draw_line(r[16], r[24], pictureBox1, g);
            d6.draw_line(r[16], r[48], pictureBox1, g);

            d6.draw_line(r[17], r[18], pictureBox1, g);
            d6.draw_line(r[17], r[21], pictureBox1, g);
            d6.draw_line(r[17], r[25], pictureBox1, g);
            d6.draw_line(r[17], r[49], pictureBox1, g);

            d6.draw_line(r[18], r[19], pictureBox1, g);
            d6.draw_line(r[18], r[22], pictureBox1, g);
            d6.draw_line(r[18], r[26], pictureBox1, g);
            d6.draw_line(r[18], r[50], pictureBox1, g);

            d6.draw_line(r[19], r[23], pictureBox1, g);
            d6.draw_line(r[19], r[27], pictureBox1, g);
            d6.draw_line(r[19], r[51], pictureBox1, g);

            d6.draw_line(r[20], r[21], pictureBox1, g);
            d6.draw_line(r[20], r[23], pictureBox1, g);
            d6.draw_line(r[20], r[28], pictureBox1, g);
            d6.draw_line(r[20], r[52], pictureBox1, g);

            d6.draw_line(r[21], r[22], pictureBox1, g);
            d6.draw_line(r[21], r[29], pictureBox1, g);
            d6.draw_line(r[21], r[53], pictureBox1, g);

            d6.draw_line(r[22], r[23], pictureBox1, g);
            d6.draw_line(r[22], r[30], pictureBox1, g);
            d6.draw_line(r[22], r[54], pictureBox1, g);

            d6.draw_line(r[23], r[31], pictureBox1, g);
            d6.draw_line(r[23], r[55], pictureBox1, g);

            d6.draw_line(r[24], r[25], pictureBox1, g);
            d6.draw_line(r[24], r[27], pictureBox1, g);
            d6.draw_line(r[24], r[28], pictureBox1, g);
            d6.draw_line(r[24], r[56], pictureBox1, g);

            d6.draw_line(r[25], r[26], pictureBox1, g);
            d6.draw_line(r[25], r[29], pictureBox1, g);
            d6.draw_line(r[25], r[57], pictureBox1, g);

            d6.draw_line(r[26], r[27], pictureBox1, g);
            d6.draw_line(r[26], r[30], pictureBox1, g);
            d6.draw_line(r[26], r[58], pictureBox1, g);

            d6.draw_line(r[27], r[31], pictureBox1, g);
            d6.draw_line(r[27], r[59], pictureBox1, g);

            d6.draw_line(r[28], r[29], pictureBox1, g);
            d6.draw_line(r[28], r[31], pictureBox1, g);
            d6.draw_line(r[28], r[60], pictureBox1, g);

            d6.draw_line(r[29], r[30], pictureBox1, g);
            d6.draw_line(r[29], r[61], pictureBox1, g);

            d6.draw_line(r[30], r[31], pictureBox1, g);
            d6.draw_line(r[30], r[62], pictureBox1, g);

            d6.draw_line(r[31], r[63], pictureBox1, g);

            d6.draw_line(r[32], r[33], pictureBox1, g);
            d6.draw_line(r[32], r[35], pictureBox1, g);
            d6.draw_line(r[32], r[36], pictureBox1, g);
            d6.draw_line(r[32], r[40], pictureBox1, g);
            d6.draw_line(r[32], r[48], pictureBox1, g);

            d6.draw_line(r[33], r[34], pictureBox1, g);
            d6.draw_line(r[33], r[37], pictureBox1, g);
            d6.draw_line(r[33], r[41], pictureBox1, g);
            d6.draw_line(r[33], r[49], pictureBox1, g);

            d6.draw_line(r[34], r[35], pictureBox1, g);
            d6.draw_line(r[34], r[38], pictureBox1, g);
            d6.draw_line(r[34], r[42], pictureBox1, g);
            d6.draw_line(r[34], r[50], pictureBox1, g);

            d6.draw_line(r[35], r[39], pictureBox1, g);
            d6.draw_line(r[35], r[43], pictureBox1, g);
            d6.draw_line(r[35], r[51], pictureBox1, g);

            d6.draw_line(r[36], r[37], pictureBox1, g);
            d6.draw_line(r[36], r[39], pictureBox1, g);
            d6.draw_line(r[36], r[44], pictureBox1, g);
            d6.draw_line(r[36], r[52], pictureBox1, g);

            d6.draw_line(r[37], r[38], pictureBox1, g);
            d6.draw_line(r[37], r[45], pictureBox1, g);
            d6.draw_line(r[37], r[53], pictureBox1, g);

            d6.draw_line(r[38], r[39], pictureBox1, g);
            d6.draw_line(r[38], r[46], pictureBox1, g);
            d6.draw_line(r[38], r[54], pictureBox1, g);

            d6.draw_line(r[39], r[47], pictureBox1, g);
            d6.draw_line(r[39], r[55], pictureBox1, g);

            d6.draw_line(r[40], r[41], pictureBox1, g);
            d6.draw_line(r[40], r[43], pictureBox1, g);
            d6.draw_line(r[40], r[44], pictureBox1, g);
            d6.draw_line(r[40], r[56], pictureBox1, g);

            d6.draw_line(r[41], r[42], pictureBox1, g);
            d6.draw_line(r[41], r[45], pictureBox1, g);
            d6.draw_line(r[41], r[57], pictureBox1, g);

            d6.draw_line(r[42], r[43], pictureBox1, g);
            d6.draw_line(r[42], r[46], pictureBox1, g);
            d6.draw_line(r[42], r[58], pictureBox1, g);

            d6.draw_line(r[43], r[47], pictureBox1, g);
            d6.draw_line(r[43], r[59], pictureBox1, g);

            d6.draw_line(r[44], r[45], pictureBox1, g);
            d6.draw_line(r[44], r[47], pictureBox1, g);
            d6.draw_line(r[44], r[60], pictureBox1, g);

            d6.draw_line(r[45], r[46], pictureBox1, g);
            d6.draw_line(r[45], r[61], pictureBox1, g);

            d6.draw_line(r[46], r[47], pictureBox1, g);
            d6.draw_line(r[46], r[62], pictureBox1, g);

            d6.draw_line(r[47], r[63], pictureBox1, g);

            d6.draw_line(r[48], r[49], pictureBox1, g);
            d6.draw_line(r[48], r[51], pictureBox1, g);
            d6.draw_line(r[48], r[52], pictureBox1, g);
            d6.draw_line(r[48], r[56], pictureBox1, g);

            d6.draw_line(r[49], r[50], pictureBox1, g);
            d6.draw_line(r[49], r[53], pictureBox1, g);
            d6.draw_line(r[49], r[57], pictureBox1, g);

            d6.draw_line(r[50], r[51], pictureBox1, g);
            d6.draw_line(r[50], r[54], pictureBox1, g);
            d6.draw_line(r[50], r[58], pictureBox1, g);

            d6.draw_line(r[51], r[55], pictureBox1, g);
            d6.draw_line(r[51], r[59], pictureBox1, g);
            
            d6.draw_line(r[52], r[53], pictureBox1, g);
            d6.draw_line(r[52], r[55], pictureBox1, g);
            d6.draw_line(r[52], r[60], pictureBox1, g);

            d6.draw_line(r[53], r[54], pictureBox1, g);
            d6.draw_line(r[53], r[61], pictureBox1, g);

            d6.draw_line(r[54], r[55], pictureBox1, g);
            d6.draw_line(r[54], r[62], pictureBox1, g);

            d6.draw_line(r[55], r[63], pictureBox1, g);

            d6.draw_line(r[56], r[57], pictureBox1, g);
            d6.draw_line(r[56], r[59], pictureBox1, g);
            d6.draw_line(r[56], r[60], pictureBox1, g);

            d6.draw_line(r[57], r[58], pictureBox1, g);
            d6.draw_line(r[57], r[61], pictureBox1, g);

            d6.draw_line(r[58], r[59], pictureBox1, g);
            d6.draw_line(r[58], r[62], pictureBox1, g);

            d6.draw_line(r[59], r[63], pictureBox1, g);

            d6.draw_line(r[60], r[61], pictureBox1, g);
            d6.draw_line(r[60], r[63], pictureBox1, g);

            d6.draw_line(r[61], r[62], pictureBox1, g);

            d6.draw_line(r[62], r[63], pictureBox1, g);
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

        private void button1_Click(object sender, EventArgs e)
        {
            d2.reset();
            d3.reset();
            d4.reset();
            d5.reset();
            d6.reset();
        }
    }
}
