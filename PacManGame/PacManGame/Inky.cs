using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Inky
    {
        public string nombre { get; set; }
        public Inky()
        {
            this.nombre = "Inky";
        }
        public void Movement()
        {
            Console.WriteLine("Inky usa la posición de PacMan y Blinky para moverse.");
        }
    }
}
