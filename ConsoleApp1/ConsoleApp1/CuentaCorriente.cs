using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BancoMundial
{
    public class CuentaCorriente: CuentaBancaria,IAuditable
    {
        public CuentaCorriente(string Direccion, string NIT, double Saldo, string Nombre, string Apellido) : base(Direccion, NIT, Saldo, Nombre, Apellido){
        }

        public void AuditarTransaccion(string tipo, double cantidad) {

            if (tipo.Equals("Depositar")){
                Console.WriteLine("Cantidad depositada: " + cantidad + "$\nSaldo actual: " + this.Saldo + "$"); 
            }
            else if(tipo.Equals("Retirar")){
                Console.WriteLine("Cantidad Retirada: " + cantidad + "$\nSaldo actual: " + this.Saldo + "$");

            }

        }

    }
}


