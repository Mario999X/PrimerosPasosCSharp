﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCapsulas.Models
{
    internal class Capsula
    {
        public int Id { get; }
        public int Pasajeros { get; set; }
        public int LaunchTime { get; set; }

        public override string ToString()
        {
            return "Cápsula: " + Id + " | Pasajeros: " + Pasajeros + " | Tiempo de lanzamiento: " + LaunchTime + " ms";
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
