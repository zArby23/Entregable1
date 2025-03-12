using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    abstract class Personaje
    {
        String nombre;
        Movimiento velMovimiento;

        public Personaje(String nombre, Movimiento velMovimiento)
        {
            this.nombre = nombre;
            this.velMovimiento = velMovimiento;
        }

        public abstract void Mover();

        public void MostrarInformación()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Velocidad de movimiento: " + velMovimiento);
        }
    }
}
