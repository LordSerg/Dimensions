using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Dimensions
{
    class d2
    {

        public static Vector E1, E2;//базисы пространства
        public double X, Y;//координаты точек для юзера
        protected double x, y;//координаты для плоскости
        protected static double Angle=0;//угол поворота
        int Size;//размер точки
        public d2()
        {
            //reset();
        }
        public d2(double X_coord,double Y_coord)
        {
            X = X_coord;
            Y = Y_coord;
            x = X * E1.C[0] + Y * E1.C[1];
            y = X * E2.C[0] + Y * E2.C[1];
            Size = 2;
        }
        public static void rotate(double angle)
        {
            Angle+=angle*Math.PI/180;//+градус
            Vector e1, e2;//временные координаты
            e1 = new Vector(1, 0);
            e2 = new Vector(0, 1);
            //так должно работать:
            //E1 = Vector.Add(Vector.M(Math.Cos(Angle), e1), Vector.M(Math.Sin(Angle), e2));
            //E2 = Vector.Add(Vector.M(-1 * Math.Sin(Angle), e1), Vector.M(Math.Cos(Angle), e2));
            //так работает:
            E1 = new Vector(Math.Cos(Angle) * (e1.C[0] + e2.C[0]), Math.Sin(Angle) * (e2.C[1] + e1.C[1]));
            E2 = new Vector(-1 * Math.Sin(Angle) * (e1.C[0] + e2.C[0]), Math.Cos(Angle) * (e2.C[1] + e1.C[1]));
            //матрица перехода:
            /* x       y
             cos(a)  sin(a)
            -sin(a)  cos(a)
             */
        }
        public static void draw_point(d2 point, PictureBox p, Graphics g)
        {//отображение точки на пикчерБоксе
            point.x = point.X * E1[0] + point.Y * E1[1];
            point.y = point.X * E2[0] + point.Y * E2[1];
            g.FillEllipse(Brushes.White, (float)point.x + p.Width / 2, (float)point.y + p.Height / 2, point.Size, point.Size);
        }
        public static void draw_line(d2 point1, d2 point2, PictureBox p, Graphics g)
        {
            point1.x = point1.X * E1[0] + point1.Y * E1[1];
            point1.y = point1.X * E2[0] + point1.Y * E2[1];
            point2.x = point2.X * E1[0] + point2.Y * E1[1];
            point2.y = point2.X * E2[0] + point2.Y * E2[1];
            g.DrawLine(Pens.White, (float)point1.x + p.Width / 2, (float)point1.y + p.Height / 2, (float)point2.x + p.Width / 2, (float)point2.y + p.Height / 2);
        }
        public static void reset()
        {//анулирование базисов (или инициализация)
            E1 = new Vector(1, 0);//базис Х
            E2 = new Vector(0, 1);//базис У
        }
    }
}
