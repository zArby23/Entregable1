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
        float velMovimiento;

        public Personaje(String nombre)
        {
            this.nombre = nombre;
            this.velMovimiento = 1;
        }

        public abstract void Mover();

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Velocidad de movimiento: " + velMovimiento);
        }
    }
}
