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

    public class ClsDatosDepartamento
    {
        Int16 pID;
        string pNombre;
        string pDescripcion;

        #region Constructor
        public ClsDatosDepartamento()
        { }

        public ClsDatosDepartamento(Int16 _ID, string _Nombre, string _Descripcion)
        {
            pID = _ID;
            pNombre = _Nombre;
            pDescripcion = _Descripcion;
        }


        #endregion
        #region Propiedades publicas
        public Int16 ID { get => pID; set => pID = value; }
        public string Nombre { get => pNombre; set => pNombre = value; }
        public string Descripcion { get => pDescripcion; set => pDescripcion = value; }

        #endregion

    }
}
