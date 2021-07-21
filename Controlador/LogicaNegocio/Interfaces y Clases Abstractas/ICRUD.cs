using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.LogicaNegocio
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */
    interface ICRUD
    {
        String Registrar();
        String Eliminar();
        String Actualizar();
        List<Object> GetListado();
    }
}
