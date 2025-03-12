using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    interface IMovible
    {
        void CambiarDireccion(Movimiento nuevaDireccion);
    }
}
