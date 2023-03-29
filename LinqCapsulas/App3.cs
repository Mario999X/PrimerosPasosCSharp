using LinqCapsulas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqCapsulas
{
    internal class App3
    {

        public const int NumCapsulas = 10;

        private static void Main()
        {
            List<Capsula> listado = ProduceCapsulas();

            List<Capsula> listadoNumPasajerosAsc =
                (from capsula in listado
                select capsula).OrderBy(x => x.Pasajeros).ToList();

            List<Capsula> listadoNumPasajerosDesc =
                (from capsula in listado
                 //orderby capsula.Pasajeros
                 select capsula).OrderByDescending(x => x.Pasajeros).ToList();

            List<Capsula> listadoIdPar =
                (from capsula in listado
                 where (capsula.Id % 2) == 0
                 select capsula).ToList();

            Console.WriteLine("Mostrando listado según el número de pasajeros ascendente: ");
            foreach(Capsula cap in listadoNumPasajerosAsc)
            {
                Console.WriteLine(cap);
            }

            Console.WriteLine("\nMostrando listado según el número de pasajeros descendente: ");
            foreach(Capsula cap in listadoNumPasajerosDesc)
            {
                Console.WriteLine(cap);
            }

            Console.WriteLine("\nMostrando listado de cápsulas con id pares: ");
            foreach(Capsula cap in listadoIdPar)
            {
                Console.WriteLine(cap);
            }

        }

        private static List<Capsula> ProduceCapsulas()
        {
            List<Capsula> listadoCapsulas = new List<Capsula>();

            int contadorId = 0;

            while (contadorId < NumCapsulas)
            {
                contadorId++;

                listadoCapsulas.Add(new Capsula(contadorId));
            }

            return listadoCapsulas;
        }
    }
}
