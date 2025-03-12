using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public abstract class CuentaBancaria
    {
        public string Direccion { get; set; }
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Saldo { get; set; }

        public CuentaBancaria(string Direccion,string NIT, double Saldo, string Nombre, string Apellido){
            this.Direccion = Direccion;
            this.NIT = NIT;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Saldo = Saldo;

        }
        public CuentaBancaria(){
            Direccion = "";
            NIT = "";
            Nombre = "";
            Apellido = "";
            Saldo = 0;
        }

        public void Depositar(double cantidad){
            Boolean opp;
            Console.WriteLine("Desea depositar " + cantidad + " a su cuenta? (s/n)");
            string rep = Console.ReadLine().ToLower();
            opp = (rep == "s") ? true : false;
            if (opp)
            {
                Saldo = Saldo + cantidad;
            }
            else return;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > Saldo){
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            else{
                Boolean opp;
                Console.WriteLine("Desea retirar " + cantidad + " a su cuenta? (s/n)");
                string rep = Console.ReadLine().ToLower();
                opp = (rep == "s") ? true : false;
                if (opp){
                    Saldo = Saldo - cantidad;
                }
                else return; 
            }

            
        }

        public double Consultar()
        {
            return Saldo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre + " " + Apellido);
            Console.WriteLine("Direccion: " + Direccion);
            Console.WriteLine("NIT: " + NIT);
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
    
}

