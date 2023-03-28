using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsyncAwait.Models
{
    public class Capsula
    {
        private int Id;
        public int Pasajeros { get; set; }
        public int LaunchTime { get; set; }

        public override string ToString()
        {
            return "Cápsula: " + Id;
        }

        public Capsula(int id)
        {
            Id = id;
            Pasajeros = GeneracionPasajeros();
            LaunchTime = GeneracionLanzamiento();
        }

        private int GeneracionPasajeros()
        {
            Random rnd = new Random();

            return rnd.Next(15, 50);
        }

        private int GeneracionLanzamiento()
        {
            Random rnd = new Random();

            return rnd.Next(500, 1000);
        }

    }
}
