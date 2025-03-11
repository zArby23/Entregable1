using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            int op = 0, sr = 0, sw = 0;
            do
            {
                if (sw == 0)
                {
                    sr = cls.Inicial();
                }

                
                sw = 1;
                if (sr == 1)
                {
                    op = cls.MenuPrincipal();
                    switch (op)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        default:
                            Console.WriteLine("Saliendo del programa hujfjjf");
                            break;

                    }//Fin switch

                }
                else
                {
                    if (sr == 2)
                    {
                        Console.WriteLine("Saliendo del programa");

                    }
                }




            }
            while (op != 5 && sr != 2);

        }










        public int Inicial()
        {
            String Mnu = "MENU INICIO\n"
                + "1. Ingresar Datos\n"
                + "2. Terminar";

            Console.WriteLine(Mnu);
            int vreUsu = 0;
            do
            {

                vreUsu = Int32.Parse(Console.ReadLine());
                if (vreUsu != 1 && vreUsu != 2)
                {
                    Console.WriteLine("Opción no valida, intente nuevamente");
                }

            } while (vreUsu != 1 && vreUsu != 2);
            return vreUsu;







        }//Fin metodo


        public int MenuPrincipal()
        {
            String menu = "MENU PRINCIPAL\n"
                + "1. Depositar\n"
                + "2. Retirar\n"
                + "3. Consultar Saldo\n"
                + "4. Mostrar informacion de la cuenta\n"
                + "5. Terminar";
            Console.WriteLine(menu);

            int vreUsu = 0;

            do
            {

                vreUsu = Int32.Parse(Console.ReadLine());
                if (vreUsu < 1 || vreUsu > 5)
                {
                    Console.WriteLine("Opción no valida, intente nuevamente");
                }

            } while (vreUsu < 1 || vreUsu > 5);
            return vreUsu;
        }//Fin metodo













    }//FIN CLASE
}//FIN NAHSCGBJYUHWSGVCYU

