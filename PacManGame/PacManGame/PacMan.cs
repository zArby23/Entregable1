using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class PacMan : Personaje, IMovible
    {
        public Movimiento DireccionActual = Movimiento.Izquierda;
        
        public PacMan(String nombre): base(nombre)
        {
        }

        public void CambiarDireccion(Movimiento nuevaDireccion)
        {

          DireccionActual = nuevaDireccion;
            Console.WriteLine("Ahora se mueve hacia " + nuevaDireccion);
        }

        public override void Mover()
        {
            switch (DireccionActual) {
                case Movimiento.Arriba: Console.WriteLine("PacMan se mueve hacia arriba"); ; break;
                case Movimiento.Abajo: Console.WriteLine("PacMan se mueve hacia abajo"); break;
                case Movimiento.Izquierda: Console.WriteLine("PacMan se mueve hacia Izquierda"); break;
                case Movimiento.Derecha: Console.WriteLine("PacMan se mueve hacia Derecha"); break;
            }
                
        }
    }
}
