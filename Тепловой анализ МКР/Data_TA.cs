using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Тепловой_анализ_МКР
{
    public static class Data_TA
    {
        public static double tau, //шаг по времени
                             tmax;//максимальное время расчета
        public static int    nx,
                             ny,
                             nz; //число расчетных точек по координатным осям
  }

}
