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
    public abstract class CastObjetos<T>
    {
       protected abstract T ObjectCastToEntidad(Object obj);
        protected abstract List<T> ObjectCastToListEntidad(List<object> obj);
    }
}
