using AsyncAwait.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class App2
    {
        public const int NumCapsulas = 10;

        public static void Main()
        {

            MisionConcurrencia();

            //MisionSincrona();
        }

        private static async void MisionConcurrencia()
        {
            Console.WriteLine("Iniciando mision con concurrencia");

            Stopwatch stopwatch = new Stopwatch();

            List<Capsula> listado = ProduceCapsulas();
            List<Task> futures = new List<Task>();

            stopwatch.Start();
            foreach (Capsula capsula in listado)
            { 
                var task = Task.Run(() => Consume(capsula));
                futures.Add(task);
            }

            Task.WaitAll(futures.ToArray());
            stopwatch.Stop();
            Console.WriteLine("Mision terminada en: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        private static void MisionSincrona()
        {
            Console.WriteLine("Iniciando mision sincrona");

            Stopwatch stopwatch = new Stopwatch();

            List<Capsula> listado = ProduceCapsulas();

            stopwatch.Start();
            foreach(Capsula capsula in listado)
            {
                Consume(capsula);
            }

            stopwatch.Stop();
            Console.WriteLine("Mision sincrona terminada en: " + stopwatch.ElapsedMilliseconds + " ms");
        }
        
        private static async Task Consume(Capsula capsula)
        {
            Console.WriteLine(Environment.CurrentManagedThreadId + " se encarga de la cápsula: " + capsula);
            Thread.Sleep(capsula.LaunchTime);
            Console.WriteLine(Environment.CurrentManagedThreadId + " lanzó la cápsula: " + capsula);
        }

        private static List<Capsula> ProduceCapsulas()
        {
            List <Capsula> listadoCapsulas = new List<Capsula>();

            int contadorId = 0;

            while(contadorId < NumCapsulas)
            {
                contadorId++;

                listadoCapsulas.Add(new Capsula(contadorId));
            }

            return listadoCapsulas;
        }
    }
}
