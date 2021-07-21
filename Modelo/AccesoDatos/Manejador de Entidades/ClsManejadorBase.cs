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
    public abstract class ClsManejadorBase<T>
    {
        //Tabla Avion en memoria - reemplazo de la BD
        private List<T> pDatos;

        protected List<T> Datos { get => pDatos; set => pDatos = value; }

        public abstract void Insertar(List<T> lst);
        public abstract void Actualizar(List<T> lst);
        public abstract void Eliminar(List<T> lst);
        public abstract List<Object> Listar();
    }
}
