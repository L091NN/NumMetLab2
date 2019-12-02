using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    class Matrix
    {
       private double[] up;
       private double[] low;
       private double[] main;
       private int size;

        public Matrix(double[] a, double[] d, double h)
        {
            int n = a.Length;
            size = n+1;

            up = new double[n+1];
            low = new double[n+1];
            main = new double[n+1];

            up[0] = 0;
            main[0] = 1;
            low[0] = 0;

            for (int i = 1; i < n; i++)
            {
                low[i] = a[i-1] / (h * h);
                main[i] = -((a[i-1] + a[i]) / (h * h) + d[i-1]);
                up[i] = a[i] / (h * h);
            }

            up[n] = 0;
            main[n] = 1;
            low[n] = 0;
        }

        public double[] Progonka(double[] b)
        {
            int n = size - 1;

            double[] res = new double[size];
            double[] alpha = new double[n];
            double[] beta = new double[n];

            alpha[0] = -up[0];
            beta[0] = b[0];

            //Прямой ход 
            for (int i = 1; i < n; i++)
            {
                alpha[i] = up[i] / (-main[i] - alpha[i-1] * low[i]);
                beta[i] = (-b[i] + low[i] * beta[i - 1]) / (-main[i] - alpha[i - 1] * low[i]);
            }

            //Обратный ход
            res[n] = (b[n] - low[n] * beta[n - 1]) / (1 + low[n] * alpha[n - 1]);

            for (int i = n - 1; i >= 0; i--)
            {
                res[i] = alpha[i] * res[i + 1] + beta[i];
            }

            return res;
        }
    }

    class Task
    {
        static double small = 0.00000000000001;

        public static double[] TestTask(int n)
        {
            double k1 = 2.09;
            double k2 = 0.09;
            double q1 = 0.3;
            double q2 = 0.09;
            double f1 = 1;
            double f2 = Math.Sin(Math.PI * 0.3);
            double m1 = 1;
            double m2 = 0;
            double ksi = 0.3;

            double[] a = new double[n];
            double[] d = new double[n - 1];
            double[] b = new double[n + 1];
            double[] res;

            b[0] = m1;
            b[n] = m2;

            double h = 1.0 / n;
            double x;

            //Расчёт компонент вектора a
            double temp = ksi / h;
            int num1 = (int)Math.Floor(temp);
            int num2 = 0;
            int num3 = 0;

            if ((temp - Math.Round(temp)) < small)
            {
                num2 = n - num1;
            }
            else
            {
                num2 = n - num1 - 1;
                num3 = 1;
            }

            //Заполнение 
            x = 0.0;
            for (int i = 0; i < num1; i++)
                a[i] = k1;

            if (num3 == 1)
            {
                x = num1 * h;
                a[num1] = h / ((ksi - x) / k1 + (x + h - ksi) / k2);
            }

            for (int i = num1 + num3; i < n; i++)
                a[i] = k2;

            //Расчёт компонент вектров d,b
            temp = (ksi + h / 2.0) / h;

            num1 = (int)Math.Floor(temp) - 1;

            if ((temp - Math.Round(temp)) < small)
            {
                num2 = n - 1 - num1;
                num3 = 0;
            }
            else
            {
                num2 = n - 2 - num1;
                num3 = 1;
            }

            //Заполнение
            x = h / 2.0;
            for (int i = 0; i < num1; i++)
            {
                d[i] = q1;
                b[i + 1] =-f1;
            }

            if (num3 == 1)
            {
                x = h / 2.0 + h * num1;
                d[num1] = q1 / h * (ksi - x);
                b[num1 + 1] = -(f1 / h * (ksi - x));
                x += h;
                d[num1] += q2 / h * (x - ksi);
                b[num1 + 1] += -(f2 / h * (x - ksi));
            }

            for (int i = num1 + num3; i < n - 1; i++)
            {
                d[i] = q2;
                b[i + 1] = -f2;
            }

            Matrix mtx = new Matrix(a,d,h);
            res = mtx.Progonka(b);

            return res;
        }
    }
}
