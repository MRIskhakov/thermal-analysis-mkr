using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тепловой_анализ_МКР
{
    class ThermalAnalysis
    {

        public static double[] systrd(double[] dd, double[] bb, double[] aa, double[] cc, int nn, double[] xx) //метод, решающий СЛАУ методом прогонки
        {
            int m, i, k;
            double[] gg = new double[100];
            double t, s, xxm;
            if (nn > 2)
            {
                m = nn - 1;
                t = bb[0];
                xx[0] = -1 * aa[0] / t;
                gg[0] = -1 * dd[0] / t;
                for (i = 1; i < nn; i++)
                {
                    k = i - 1;
                    t = cc[i];
                    s = bb[i] + t * xx[k];
                    xx[i] = -1 * aa[i] / s;
                    gg[i] = -1 * (dd[i] + t * gg[k]) / s;
                }
                xxm = xx[m - 1];
                t = cc[nn - 1];
                xx[nn - 1] = -1 * (t * gg[m - 1] + dd[nn - 1]) / (bb[nn - 1] + t * xxm);
                for (i = m - 1; i >= 0; i--)
                    xx[i] = xx[i] * xx[i + 1] + gg[i];
                return xx;
            }
            else
                return xx = null;
        }


        public Tuple<double[], double[], double[], double[], int> start()
        {

            int nx = Data_TA.nx,
                ny = Data_TA.ny,
                nz = Data_TA.nz;
            double tau = Data_TA.tau,
                   tmax = Data_TA.tmax,
                   dx = Data_ElectronicMeans.dx,
                   dy = Data_ElectronicMeans.dy,
                   dz = Data_ElectronicMeans.dz,
                   alx = Data_ElectronicMeans.alx,
                   aly = Data_ElectronicMeans.aly,
                   alz = Data_ElectronicMeans.alz,
                   cr = Data_ElectronicMeans.cr,
                   ro = Data_ElectronicMeans.ro,
                   qv = Data_ElectronicMeans.qv,
                   t0 = Data_ElectronicMeans.t0,
                   kof = Data_ElectronicMeans.kof;
            double alf0 = Data_ElectronicMeans.alf0,
                   alf1 = Data_ElectronicMeans.alf1,
                   alf2 = Data_ElectronicMeans.alf2,
                   alf3 = Data_ElectronicMeans.alf3,
                   alf4 = Data_ElectronicMeans.alf4,
                   alf5 = Data_ElectronicMeans.alf5;
            double[,,] u = new double[Data_TA.nx, Data_TA.ny, Data_TA.nz];
            double[,,] qw = new double[Data_TA.nx, Data_TA.ny, Data_TA.nz];
            double[] bx = new double[(int)nx],
                     by = new double[(int)ny],
                     bz = new double[(int)nz];
            double[] t = new double[7];
            double[] qs = new double[6];
            qs[0] = 10;
            qs[1] = 10;
            qs[2] = 10;
            qs[3] = 10;
            qs[4] = 10;
            qs[5] = 10;


            //Блок 1
            if ((nx <= 3) || (ny <= 3) || (nz <= 3))
                return null;
            for (int k = 0; k < nz; k++)
                for (int m = 0; m < ny; m++)
                    for (int n = 0; n < nx; n++)
                        u[k, m, n] = t0;
            //Блок 2
            for (int k = 0; k < nz; k++)
                for (int m = 0; m < ny; m++)
                    for (int n = 0; n < nx; n++)
                        qw[n, m, k] = qv / (nx * ny * nz);

            //for (int k = 0; k < nx; k++)
            //    for (int m = 0; m < ny; m++)
            //        for (int n = 0; n < nx; n++)
            //            qw[k, m, n] = kof * qw[k, m, n] * qw[k, m, n];

            int nx1 = nx - 1,
                ny1 = ny - 1,
                nz1 = nz - 1;

            double hx = dx / nx1,
                   hy = dy / ny1,
                   hz = dz / nz1;

            //Блок 3
            double r1 = cr * hx * hx / alx / tau,
                   r2 = cr * hy * hy / aly / tau,
                   r3 = cr * hz * hz / alz / tau,
                   r4,
                   r5,
                   r6;

            //for (int i = 0; i < 6; i++) //  На всех 6 - и поверхностях
            //    alf[i] = 10;

            int nmax = nx;
            if (ny > nmax)
                nmax = ny;
            if (nz > nmax)
                nmax = nz;

            //Блок 4
            for (int n = 1; n < nx1; n++)
                bx[n] = (-2) - r1;
            for (int m = 1; m < ny1; m++)
                by[m] = (-2) - r2;
            for (int k = 1; k < nz1; k++)
                bz[k] = (-2) - r3;

            double[] a = new double[nmax];
            double[] c = new double[nmax];
            for (int n = 0; n < nmax; n++)
            {
                a[n] = 1;
                c[n] = 1;
            }
            c[0] = 0;

            //Блок 5
            for (double time = tau; time < tmax;)
            {
                time = time + tau;
                a[nx1] = 0;
                bx[0] = (-1) - alf0 * hx / alx - r1 / 2;
                bx[nx1] = (-1) - alf1 * hx / alx - r1 / 2;

                double[] w = new double[nmax],
                         d = new double[nmax],
                         g = new double[nmax],
                         b = new double[nmax];

                //Блок 5-6
                for (int k = 0; k < nz; k++)
                    for (int m = 0; m < ny; m++)
                    {
                        r4 = qw[k, m, 0] * hx * hx / alx / 3;
                        for (int n = 1; n < nx1; n++)
                        {
                            d[n] = r4 + r1 * u[k, m, n];
                        }
                        d[0] = qs[0] * hx / alx + (r4 + r1 * u[k, m, 0]) / 2;
                        d[nx1] = qs[1] * hx / alx + (r4 + r1 * u[k, m, nx1]) / 2;
                        w = systrd(d, bx, a, c, nx, w);
                        //Блок 7
                        for (int n = 0; n < nx; n++)
                            u[k, m, n] = w[n];
                    }
                a[nx1] = 1;

                //Блок 8-9
                by[0] = (-1) - alf2 * hy / aly - r2 / 2;
                by[ny1] = (-1) - alf3 * hy / aly - r2 / 2;
                a[ny1] = 0;
                for (int k = 0; k < nz; k++)
                    for (int n = 0; n < nx; n++)
                    {
                        r5 = qw[k, 0, n] * hy * hy / aly / 3;
                        for (int m = 1; m < ny1; m++)
                        {
                                d[m] = r5 + r2 * u[k, m, n];
                        }
                        d[0] = qs[2] * hy / aly + (r5 + r2 * u[k, 0, n]) / 2;
                        d[ny1] = qs[3] * hy / aly  + (r5 + r2 * u[k, ny1, n]) / 2;
                        w = systrd(d, by, a, c, ny, w);
                        //Блок 10
                        for (int m = 0; m < ny; m++)
                            u[k, m, n] = w[m];
                    }
                a[ny1] = 1;

                //Блок 11-12
                a[nz1] = 0;
                bz[0] = (-1) - alf4 * hz / alz - r3 / 2;
                bz[nz1] = (-1) - alf5 * hz / alz - r3 / 2;
                for (int n = 0; n < nx; n++)
                    for (int m = 0; m < ny; m++)
                    {
                        r6 = qw[0, m, n] * hz * hz / alz / 3;
                        for (int k = 1; k < nz1; k++)
                        {
                            d[k] = r6 + r3 * u[k, m, n];
                        }
                        d[0] = qs[4] * hz / alz + (r6 + r3 * u[0, m, n]) / 2;
                        d[nz1] = qs[5] * hz / alz  + (r6 + r3 * u[nz1, m, n]) / 2;
                        w = systrd(d, bz, a, c, nz, w);
                        //Блок 13
                        for (int k = 0; k < nz; k++)
                            u[k, m, n] = w[k];
                    }
                a[nz1] = 1;

                //Блок 14

                double ts1 = 0,
                       ts2 = 0,
                       ts3 = 0,
                       ts4 = 0,
                       ts5 = 0,
                       ts6 = 0;
                for (int m = 1; m < ny; m++)
                    for (int k = 1; k < nz; k++)
                    {
                        ts1 = ts1 + u[1, m, k];
                        ts2 = ts2 + u[nx1, m, k];
                    }
                for (int n = 1; n < nx; n++)
                    for (int k = 1; k < nz; k++)
                    {
                        ts3 = ts3 + u[n, 1, k];
                        ts4 = ts4 + u[n, ny1, k];
                    }
                for (int n = 1; n < nx; n++)
                    for (int m = 1; m < ny; m++)
                    {
                        ts5 = ts5 + u[n, m, 1];
                        ts6 = ts6 + u[n, m, nz1];
                    }
                t[1] = ts1 / ny / nz;
                t[2] = ts2 / ny / nz;
                t[3] = ts3 / nx / nz;
                t[4] = ts4 / nx / nz;
                t[5] = ts5 / nx / ny;
                t[6] = ts6 / nx / ny;





            }

            double[] averageX = new double[nmax+1];
            double[] averageY = new double[nmax+1];
            double[] averageZ = new double[nmax+1];

            for (int k = 1; k < nz; k++)
            {
                averageX[k] = u[k, (int)ny / 2, (int)nx / 2];
            }
            averageX[0] = t[1];
            averageX[nz] = t[3];

            for (int m = 1; m < ny; m++)
            {
                averageY[m] = u[(int)nz / 2, m, (int)nx / 2];
            }
            averageY[0] = t[2];
            averageY[ny] = t[4];

            for (int n = 1; n < nx; n++)
            {
                averageZ[n] = u[(int)nz / 2, (int)ny / 2, n];
            }
            averageZ[0] = t[5];
            averageZ[nx] = t[6];

            return new Tuple<double[], double[], double[], double[], int>(averageX, averageY, averageZ, t, nmax); ;
        }

    }
}
