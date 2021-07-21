using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.AccesoDatos
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */
    public class ClsManejador
    {
        private ClsManejador_Usuario pUsuario = new ClsManejador_Usuario();

        public ClsManejador_Usuario Usuario { get => pUsuario; set => pUsuario = value; }
    }
}


