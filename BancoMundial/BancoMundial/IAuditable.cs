﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    interface IAuditable
    {
        void AuditarTransaccion(string tipo, double cantidad) { }
    }
}
