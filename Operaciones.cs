using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        public string metrosKilometros(double metros)
        {
            return metros * 0.001 + " klm";
        }

        public string metrosCentimetros(double metros)
        {
            return metros * 100 + " cm";
        }


        public string metrosMilimetros(double metros)
        {
            return metros * 1000 + " mm";
        }
    }
}
