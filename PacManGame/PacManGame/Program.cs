using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Program
    {
        public static void Main(String[] args)
        {
            Program Principal = new Program();
            int jugar,opcion,fantasma;
            Movimiento nuevaDir;
            do
            {
                jugar = Principal.Inicial();
                if (jugar == 1)
                {
                    Console.WriteLine("Ingrese el nombre de su personaje");
                    string nombre = Console.ReadLine();

                    PacMan pacman = new PacMan(nombre);

                    do
                    {
                        opcion = Principal.MenuDeJuego();

                        switch (opcion)
                        {
                            case 1:
                                pacman.Mover();
                                break;
                            case 2:
                                Boolean respuesta = false;
                                do
                                {
                                    fantasma = Principal.MenuFantasmas();

                                    switch (fantasma)
                                    {
                                        case 1:
                                            Pinky pinky = new Pinky();
                                            pinky.Movement();
                                            respuesta = true;
                                            break;

                                        case 2:
                                            Blinky blinky = new Blinky();
                                            blinky.Movement();
                                            respuesta = true;
                                            break;

                                        case 3:
                                            Inky inky = new Inky(); 
                                            inky.Movement();
                                            respuesta = true;
                                            break;

                                        case 4:
                                            Clyde clyde = new Clyde();
                                            clyde.Movement();
                                            respuesta = true;
                                            break;

                                        default:
                                            Console.WriteLine("Saliendo");
                                            respuesta = true;
                                            break;
                                    }
                                } while (fantasma < 5 || respuesta == false);
                                break;
                            case 3:

                                Console.WriteLine("¿A donde te quieres mover? (Selecciona el número)\n"
                                                                + "1. Arriba\n"
                                                                + "2. Abajo\n"
                                                                + "3. Izquierda\n"
                                                                + "4. Derecha\n"
                                                                + "5. Cerrar");
                                int respCase3 = Convert.ToInt32(Console.ReadLine());
                                switch (respCase3)
                                {
                                    case 1:
                                        nuevaDir = Movimiento.Arriba;
                                        pacman.CambiarDireccion(nuevaDir);
                                        break;
                                    case 2:
                                        nuevaDir = Movimiento.Abajo;
                                        pacman.CambiarDireccion(nuevaDir);
                                        break;
                                    case 3:
                                        nuevaDir = Movimiento.Izquierda;
                                        pacman.CambiarDireccion(nuevaDir);
                                        break;
                                    case 4:
                                        nuevaDir = Movimiento.Derecha;
                                        pacman.CambiarDireccion(nuevaDir);
                                        break;
                                }
                                                             
                                break;
                            case 4:
                                pacman.MostrarInformacion();
                                break;
                            default:
                                Console.WriteLine("Saliendo");
                                break;

                        }


                    } while (opcion < 5);
                }

                else
                {
                    Console.WriteLine("Hasta luego usuario");
                }
                       

            } while (jugar == 1);
        }

        
        
        
        public int Inicial()
        {

            Console.WriteLine("¿Deseas Jugar?\n"
                + "1. Si\n"
                + "2. No");
            int Auxiliar = 0;
            do
            {

                Auxiliar = Int32.Parse(Console.ReadLine());
                if (Auxiliar != 1 && Auxiliar != 2)
                {
                    Console.WriteLine("Opción no valida, intente nuevamente");
                }

            } while (Auxiliar != 1 && Auxiliar != 2);
            return Auxiliar;
        }

        public  int MenuDeJuego()
        {
          
            Console.WriteLine("¿Que deseas hacer?\n"
                + "1. Mover a Pac-Man\n"
                + "2. Mover los Fantasmas\n"
                + "3. Cambiar direccion de movimiento\n"
                + "4. Mostrar informacion de los personajes\n"
                + "5. Cerrar");

            int Auxiliar;

            do
            {
                Auxiliar = Int32.Parse(Console.ReadLine());

                if(Auxiliar < 1 || Auxiliar > 5)
                {

                    Console.WriteLine("Opcion no valida, tome un numero entre el 1 y el 5");
                }

            } while (Auxiliar < 1 || Auxiliar > 5);

            return Auxiliar;

        }


        public int MenuFantasmas()
        {

            Console.WriteLine("¿Que Fantasma quieres mover?\n"
                + "1. Pinky(Rosado)\n"
                + "2. Blinky(Rojo)\n"
                + "3. Inky(Celeste)\n"
                + "4. Clyde(Naranja)\n"
                + "5. Cerrar");

            int Auxiliar;

            do
            {
                Auxiliar = Int32.Parse(Console.ReadLine());

                if (Auxiliar < 1 || Auxiliar > 5)
                {

                    Console.WriteLine("Opcion no valida, tome un numero entre el 1 y el 5");
                }

            } while (Auxiliar < 1 || Auxiliar > 5);

            return Auxiliar;

        }
    }
}