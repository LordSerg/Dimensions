using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Dimensions
{
    class d5
    {
        public static Vector E1, E2, E3, E4, E5;//базис
        public double X, Y, Z, T, U; //координаты точки(для юзера)
        protected double x, y, z, t, u;//координаты (для компьютера)
        protected static double a1, a2, a3, a4, a5, a6, a7, a8, a9, ax;
        public d5() { }
        public d5(double x_coord, double y_coord, double z_coord, double t_coord, double u_coord)
        {
            reset();
            X = x_coord;
            Y = y_coord;
            Z = z_coord;
            T = t_coord;
            U = u_coord;
            x = X * E1[0] + Y * E1[1] + Z * E1[2] + T * E1[3] + U * E1[4];
            y = X * E2[0] + Y * E2[1] + Z * E2[2] + T * E2[3] + U * E2[4];
            z = X * E3[0] + Y * E3[1] + Z * E3[2] + T * E3[3] + U * E3[4];
            t = X * E4[0] + Y * E4[1] + Z * E4[2] + T * E4[3] + U * E4[4];
            u = X * E5[0] + Y * E5[1] + Z * E5[2] + T * E5[3] + U * E5[4];
        }
        public static void rotate(double angle1, double angle2, double angle3, double angle4, double angle5, double angle6, double angle7, double angle8, double angle9, double angle10)
        {
            a1 += angle1 * Math.PI / 180;
            a2 += angle2 * Math.PI / 180;
            a3 += angle3 * Math.PI / 180;
            a4 += angle4 * Math.PI / 180;
            a5 += angle5 * Math.PI / 180;
            a6 += angle6 * Math.PI / 180;
            a7 += angle7 * Math.PI / 180;
            a8 += angle8 * Math.PI / 180;
            a9 += angle9 * Math.PI / 180;
            ax += angle10 * Math.PI / 180;

            Vector e1, e2, e3, e4, e5;
            e1 = new Vector(1, 0, 0, 0, 0);
            e2 = new Vector(0, 1, 0, 0, 0);
            e3 = new Vector(0, 0, 1, 0, 0);
            e4 = new Vector(0, 0, 0, 1, 0);
            e5 = new Vector(0, 0, 0, 0, 1);
            e1 = E1;
            e2 = E2;
            e3 = E3;
            e4 = E4;
            e5 = E5;
            E1 = new Vector(Math.Cos(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Cos(ax)*(e1[0] + e2[0] + e3[0] + e4[0] + e5[0]),
                Math.Cos(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Sin(ax)*(e1[1] + e2[1] + e3[1] + e4[1] + e5[1]),
                Math.Cos(a4)*Math.Cos(a7)*Math.Sin(a9)*(e1[2] + e2[2] + e3[2] + e4[2] + e5[2]),
                Math.Cos(a4)*Math.Sin(a7)*(e1[3] + e2[3] + e3[3] + e4[3] + e5[3]),
                Math.Sin(a4)*(e1[4] + e2[4] + e3[4] + e4[4] + e5[4]));
            E2 = new Vector((-Math.Sin(a3) * Math.Sin(a4) * Math.Cos(a7) * Math.Cos(a9) * Math.Cos(ax) - Math.Cos(a3) * Math.Sin(a6) * Math.Sin(a7) * Math.Cos(a9) * Math.Cos(ax) - Math.Cos(a3) * Math.Cos(a6) * Math.Cos(a8) * Math.Sin(ax) - Math.Cos(a3) * Math.Cos(a6) * Math.Sin(a8) * Math.Sin(a9) * Math.Cos(ax)) * (e1[0] + e2[0] + e3[0] + e4[0] + e5[0]),
                (-Math.Sin(a3) * Math.Sin(a4) * Math.Cos(a7) * Math.Cos(a9) * Math.Sin(ax) - Math.Cos(a3) * Math.Sin(a6) * Math.Sin(a7) * Math.Cos(a9) * Math.Sin(ax) + Math.Cos(a3) * Math.Cos(a6) * Math.Cos(a8) * Math.Cos(ax) - Math.Cos(a3) * Math.Cos(a6) * Math.Sin(a8) * Math.Sin(a9) * Math.Sin(ax)) * (e1[1] + e2[1] + e3[1] + e4[1] + e5[1]),
                (-Math.Sin(a3) * Math.Sin(a4) * Math.Cos(a7) * Math.Sin(a9) - Math.Cos(a3) * Math.Sin(a6) * Math.Sin(a7) * Math.Sin(a9) + Math.Cos(a3) * Math.Cos(a6) * Math.Sin(a8) * Math.Cos(a9)) * (e1[2] + e2[2] + e3[2] + e4[2] + e5[2]),
                (-Math.Sin(a3) * Math.Sin(a4) * Math.Sin(a7) + Math.Cos(a3) * Math.Sin(a6) * Math.Cos(a7)) * (e1[3] + e2[3] + e3[3] + e4[3] + e5[3]),
                (Math.Sin(a3) * Math.Cos(a4)) * (e1[4] + e2[4] + e3[4] + e4[4] + e5[4]));
            E3 = new Vector((-Math.Sin(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Sin(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)-Math.Cos(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Sin(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Cos(a8)*Math.Sin(ax)+Math.Sin(a5)*Math.Sin(a6)*Math.Cos(a8)*Math.Cos(a2)*Math.Sin(ax)+Math.Cos(a2)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(ax)+Math.Sin(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)+Math.Cos(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)-Math.Cos(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Cos(ax))*(e1[0] + e2[0] + e3[0] + e4[0] + e5[0]),
                (-Math.Sin(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Sin(ax)+Math.Sin(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Sin(ax)-Math.Cos(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Sin(ax)-Math.Sin(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Cos(a8)*Math.Cos(ax)-Math.Cos(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Cos(a8)*Math.Cos(ax)-Math.Cos(a2)*Math.Cos(a5)*Math.Sin(a8)*Math.Cos(ax)+Math.Sin(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)+Math.Cos(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)-Math.Cos(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Sin(ax))*(e1[1] + e2[1] + e3[1] + e4[1] + e5[1]),
                (-Math.Sin(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Sin(a9)+Math.Sin(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Sin(a9)-Math.Cos(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Sin(a9)-Math.Sin(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Cos(a9)-Math.Cos(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Cos(a9)+Math.Cos(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Cos(a9))*(e1[2] + e2[2] + e3[2] + e4[2] + e5[2]),
                (-Math.Sin(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Sin(a7)-Math.Sin(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Cos(a7)+Math.Cos(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Cos(a7))*(e1[3] + e2[3] + e3[3] + e4[3] + e5[3]),
                (Math.Sin(a2)*Math.Cos(a3)*Math.Cos(a4))*(e1[4] + e2[4] + e3[4] + e4[4] + e5[4]));
            E4 = new Vector((-Math.Sin(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)-Math.Cos(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Cos(a8)*Math.Sin(ax)-Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Cos(a8)*Math.Sin(ax)-Math.Sin(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(ax)+Math.Cos(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(ax)-Math.Cos(a1)*Math.Sin(a5)*Math.Sin(a8)*Math.Sin(ax)+Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)-Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)+Math.Sin(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Cos(ax))*(e1[0] + e2[0] + e3[0] + e4[0] + e5[0]),
                (-Math.Sin(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Sin(ax)+Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Sin(ax)+Math.Sin(a1)* Math.Sin(a2) * Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)* Math.Cos(a9) * Math.Sin(ax)- Math.Cos(a1) * Math.Cos(a5) * Math.Cos(a6) * Math.Sin(a7) * Math.Cos(a9) * Math.Sin(ax) -Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Cos(a8)*Math.Cos(ax)+Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Cos(a8)*Math.Cos(ax)+Math.Sin(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Sin(a8)*Math.Cos(ax)-Math.Cos(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Cos(a8)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a5)*Math.Sin(a8)*Math.Cos(ax)+Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)-Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)+Math.Sin(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Sin(ax)+Math.Cos(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)+Math.Cos(a1)*Math.Sin(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Sin(ax))*(e1[1] + e2[1] + e3[1] + e4[1] + e5[1]),
                (-Math.Sin(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Sin(a9)+Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Sin(a9)+Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Sin(a9)-Math.Cos(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Sin(a9)-Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Cos(a9)+Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Cos(a9)-Math.Sin(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Cos(a9)-Math.Cos(a1)*Math.Cos(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Cos(a9)-Math.Cos(a1)*Math.Sin(a5)*Math.Cos(a8)*Math.Cos(a9))*(e1[2] + e2[2] + e3[2] + e4[2] + e5[2]),
                (-Math.Sin(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Sin(a7)-Math.Sin(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Cos(a7)-Math.Sin(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Cos(a7)+Math.Cos(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Cos(a7))*(e1[3] + e2[3] + e3[3] + e4[3] + e5[3]),
                (Math.Sin(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Cos(a4))*(e1[4] + e2[4] + e3[4] + e4[4] + e5[4]));
            E5 = new Vector((-Math.Cos(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Sin(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Cos(ax)+Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Cos(a8)*Math.Sin(ax)-Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Cos(a8)*Math.Sin(ax)-Math.Cos(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(ax)-Math.Sin(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(ax)+Math.Sin(a1)*Math.Sin(a5)*Math.Sin(a8)*Math.Sin(ax)+Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)-Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Cos(ax)-Math.Sin(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(a9)*Math.Cos(ax)-Math.Sin(a1)*Math.Sin(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Cos(ax))*(e1[0] + e2[0] + e3[0] + e4[0] + e5[0]),
                (-Math.Cos(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Cos(a9)*Math.Sin(ax)+Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Sin(ax)+Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Sin(ax)+Math.Sin(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Cos(a9)*Math.Sin(ax)-Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Cos(a8)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Cos(a8)*Math.Cos(ax)+Math.Cos(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Sin(a8)*Math.Cos(ax)+Math.Sin(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Cos(a8)*Math.Cos(ax)-Math.Sin(a1)*Math.Sin(a5)*Math.Sin(a8)*Math.Cos(ax)+Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)-Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)+Math.Cos(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Sin(ax)-Math.Sin(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Sin(a8)*Math.Sin(a9)*Math.Sin(ax)-Math.Sin(a1)*Math.Sin(a5)*Math.Cos(a8)*Math.Sin(a9)*Math.Sin(ax))*(e1[1] + e2[1] + e3[1] + e4[1] + e5[1]),
                (-Math.Cos(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Cos(a7)*Math.Sin(a9)+Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Sin(a7)*Math.Sin(a9)+Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Sin(a9)+Math.Sin(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Sin(a7)*Math.Sin(a9)-Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Cos(a6)*Math.Sin(a8)*Math.Cos(a9)+Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Sin(a6)*Math.Sin(a8)*Math.Cos(a9)-Math.Cos(a1)*Math.Sin(a2)*Math.Cos(a5)*Math.Cos(a8)*Math.Cos(a9)+Math.Sin(a1)*Math.Sin(a6)*Math.Cos(a5)*Math.Sin(a8)*Math.Cos(a9)+Math.Sin(a1)*Math.Sin(a5)*Math.Cos(a8)*Math.Cos(a9))*(e1[2] + e2[2] + e3[2] + e4[2] + e5[2]),
                (-Math.Cos(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Sin(a4)*Math.Sin(a7)-Math.Cos(a1)*Math.Cos(a2)*Math.Sin(a3)*Math.Sin(a6)*Math.Cos(a7)-Math.Cos(a1)*Math.Sin(a2)*Math.Sin(a5)*Math.Cos(a6)*Math.Cos(a7)-Math.Sin(a1)*Math.Cos(a5)*Math.Cos(a6)*Math.Cos(a7))*(e1[3] + e2[3] + e3[3] + e4[3] + e5[3]),
                (Math.Cos(a1)*Math.Cos(a2)*Math.Cos(a3)*Math.Cos(a4))*(e1[4] + e2[4] + e3[4] + e4[4] + e5[4]));
        }

        public static void draw_point(d5 point, PictureBox p, Graphics g)
        {
            point.x = point.X * E4[0] + point.Y * E4[1] + point.Z * E4[2] + point.T * E4[3] + point.U * E4[4];
            point.y = point.X * E5[0] + point.Y * E5[1] + point.Z * E5[2] + point.T * E5[3] + point.U * E5[4];
            g.FillEllipse(Brushes.White, (float)point.x + p.Width / 2, (float)point.y + p.Height / 2, 2, 2);
        }
        public static void draw_line(d5 point1, d5 point2, PictureBox p, Graphics g)
        {
            point1.x = point1.X * E4[0] + point1.Y * E4[1] + point1.Z * E4[2] + point1.T * E4[3] + point1.U * E4[4];
            point1.y = point1.X * E5[0] + point1.Y * E5[1] + point1.Z * E5[2] + point1.T * E5[3] + point1.U * E5[4];
            point2.x = point2.X * E4[0] + point2.Y * E4[1] + point2.Z * E4[2] + point2.T * E4[3] + point2.U * E4[4];
            point2.y = point2.X * E5[0] + point2.Y * E5[1] + point2.Z * E5[2] + point2.T * E5[3] + point2.U * E5[4];
            g.DrawLine(Pens.White, (float)point1.x + p.Width / 2, (float)point1.y + p.Height / 2, (float)point2.x + p.Width / 2, (float)point2.y + p.Height / 2);
        }
        public static void reset()
        {
            E1 = new Vector(1, 0, 0, 0, 0);
            E2 = new Vector(0, 1, 0, 0, 0);
            E3 = new Vector(0, 0, 1, 0, 0);
            E4 = new Vector(0, 0, 0, 1, 0);
            E5 = new Vector(0, 0, 0, 0, 1);
        }
    }
}
