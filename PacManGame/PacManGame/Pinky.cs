using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    
    class Pinky
    {
            public string nombre {  get; set; }
            public Pinky()
        {
            this.nombre = "Pinky";
        }
            public void Movement()
            {
            Console.WriteLine("Pinky intenta interceptar a Pac-Man adelantandose a su posición");            
            }


    }
}
