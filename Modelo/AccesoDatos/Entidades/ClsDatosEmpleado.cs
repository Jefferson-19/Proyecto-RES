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
    public class ClsDatosEmpleado:ClsDatosPersona
    {        
        double pSueldo;
        DateTime pFechaEntrada;
        DateTime pFechaSalida;

        #region Constructor
        public ClsDatosEmpleado() : base()
        { }
        public ClsDatosEmpleado(Int32 _ID) : base(_ID)
        { }
        public ClsDatosEmpleado(Int32 _ID, Int16 _IDUsuarioAdd, Int16 _IDUsuarioUpd, Int16 _IDDepartamento, string _Documento, string _Nombre, string _Apellido, string _Telefono, string _Direccion, bool _Estado, byte[] _Foto, DateTime _FechaAdd, DateTime _FechaUpd, double _Sueldo, DateTime _FechaEntrada,DateTime _FechaSalida) 
            :base( _ID, _IDUsuarioAdd,  _IDUsuarioUpd,  _IDDepartamento, _Documento,  _Nombre,  _Apellido,  _Telefono,  _Direccion,  _Estado, _Foto,  _FechaAdd,  _FechaUpd)
        {
            pSueldo=_Sueldo;
            pFechaEntrada=_FechaEntrada;
            pFechaSalida=_FechaSalida;
        }
        #endregion
        #region Propiedades publicas
        public double Sueldo { get => pSueldo; set => pSueldo = value; }
        public DateTime FechaEntrada { get => pFechaEntrada; set => pFechaEntrada = value; }
        public DateTime FechaSalida { get => pFechaSalida; set => pFechaSalida = value; }
        #endregion
    }
}
