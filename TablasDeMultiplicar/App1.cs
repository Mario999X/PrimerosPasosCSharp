using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDeMultiplicar
{
    internal class App1
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Escriba el número para mostrar su tabla: ");

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++ )
            {
                int respuesta = i * num;
                Console.WriteLine(respuesta);
            }
        }
    }
}
