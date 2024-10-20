using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class ConvertirMetros: Operaciones
    {
        public void Imprimir(double metros)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("     C O N V E R T I R   M E T R O S"     );
            Console.WriteLine("*****************************************");
            Console.WriteLine("Resultado: ");
            Console.WriteLine($"{metros} mts a Kilometros es: {this.metrosKilometros(metros)}");
            Console.WriteLine($"{metros} mts a Centimetros es: {this.metrosCentimetros(metros)}");
            Console.WriteLine($"{metros} mts a Milimetros es: {this.metrosMilimetros(metros)}");
        }
    }
}
