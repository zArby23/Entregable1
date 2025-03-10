using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    interface IAuditable
    {
        public void AuditarTransaccion(string tipo, float cantidad) { }
    }
}
