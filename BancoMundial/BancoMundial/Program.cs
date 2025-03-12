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
            
            Program cls = new Program();
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
                    string Direccion, NIT, Nombre, Apellido;
                    double Saldo;

                    Console.WriteLine("Ingrese el Nombre del usuario: ");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del usuario: ");
                    Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el NIT/Cedula del usuario: ");
                    NIT = Console.ReadLine();
                    Console.WriteLine("Ingrese la Direccion del usuario: ");
                    Direccion = Console.ReadLine();
                    Console.WriteLine("Ingrese el Saldo del usuario: ");
                    Saldo = Double.Parse(Console.ReadLine());

                    CuentaCorriente CuentaCor = new CuentaCorriente(Direccion, NIT, Saldo, Nombre, Apellido);


                    do
                    {

                        op = cls.MenuPrincipal();
                        switch (op)
                        {
                            case 1:
                                String Tipo = "Depositar";
                                double deposito;

                                Console.WriteLine("Ingrese el valor a Depositar: ");


                                deposito = Double.Parse(Console.ReadLine());
                                CuentaCor.Depositar(deposito);
                                CuentaCor.AuditarTransaccion(Tipo, deposito);
                                break;
                            case 2:
                                Tipo = "Retirar";

                                Console.WriteLine("Ingrese el valor a Retirar: ");

                                deposito = Double.Parse(Console.ReadLine());
                                CuentaCor.Retirar(deposito);
                                CuentaCor.AuditarTransaccion(Tipo, deposito);

                                break;
                            case 3:

                                Console.WriteLine(CuentaCor.Consultar());

                                break;
                            case 4:

                                CuentaCor.MostrarInformacion();

                                break;
                            default:

                                Console.WriteLine("¿Desea ingresar nuevos datos de usuario?: \n1 = si  \n2 = no");
                                sr = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("Saliendo del menu principal");
                                break;
                        }

                    } while (op < 5 && op > 0);

                }
                else
                {
                    if (sr == 2)
                    {
                        Console.WriteLine("Saliendo del programa");

                    }
                }




            }
            while (sr != 2);

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

            int vreUsu;

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

