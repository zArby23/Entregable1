using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    internal class Personaje
    {
        String nombre;
        Movimiento velMovimiento;

        public Personaje(String nombre, Movimiento velMovimiento)
        {
            this.nombre = nombre;
            this.velMovimiento = velMovimiento;
        }

        public void Mover()
        {
            Console.WriteLine("Moviendo personaje");
        }

        public void MostrarInformación()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Velocidad de movimiento: " + velMovimiento);
        }
    }
}
