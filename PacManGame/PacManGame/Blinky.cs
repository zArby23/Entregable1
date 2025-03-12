using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Blinky 
    {
        public string nombre { get; set; }
        public Blinky()
        {
            this.nombre = "Blinky";
        }
        public void Movement()
        {
            Console.WriteLine("Blinky se acerca directamente a PACMAN");
        }
    }  
}
