using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BancoMundial
{
    public class CuentaCorriente: CuentaBancaria
    {
        public CuentaCorriente(string Direccion, string NIT, double Saldo, string Nombre, string Apellido) : base(Direccion, NIT, Saldo, Nombre, Apellido){
        }
    }
}


