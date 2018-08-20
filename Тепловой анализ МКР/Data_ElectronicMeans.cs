using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Тепловой_анализ_МКР
{
    public static class Data_ElectronicMeans
    {
        public static double dx, //размер по Х
                             dy, //размер по Y
                             dz, //размер по Z
                             alx, //теплопроводность по оси x
                             aly, //теплопроводность по оси y
                             alz, //теплопроводнсть по оси z
                             cr, //теплоемкость
                             ro, //плотность
                             qv, //мощность внутреннего тепловыделения
                             t0, //начальный температурный перегрев
                             kof; //это 0.034*kof
        public static double alf0, //коэффициенты теплоотдачи на шести поверхностях
                             alf1,
                             alf2,
                             alf3,
                             alf4,
                             alf5;
        public static string DB_path;
    }
}
