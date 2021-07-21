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
    public class ClsDatosUsuario
    {
        Int16 pID;
        Perfiles pIDPerfil;
        string pNombre;
        string pNickName;
        byte[] pPassword_HASH;
        byte[] pPassword_SALT;
        DateTime pFechCreacion;
        DateTime pFechActualizacion;
        bool pActivo;

        #region Constructor
        public ClsDatosUsuario(Int16 _ID)
        {
            pID = _ID;
        }
        public ClsDatosUsuario( )
        {
           
        }
        public ClsDatosUsuario(Int16 _ID,Perfiles _IDPerfil,string _Nombre, string _NickName, byte[] _Password_HASH, byte[] _Password_SALT, DateTime _FechCreacion,   DateTime _FechActualizacion, bool _Activo)
        {
            pID= _ID;
            pIDPerfil= _IDPerfil;
            pNombre= _Nombre;
            pNickName= _NickName;
            pPassword_HASH= _Password_HASH;
            pPassword_SALT= _Password_SALT;
            pFechCreacion= _FechCreacion;
            pFechActualizacion=_FechActualizacion;
            pActivo= _Activo;
        }
        #endregion

        #region Propiedades publicas
        public Int16 ID { get => pID; set => pID = value; }
        public Perfiles IDPerfil { get => pIDPerfil; set => pIDPerfil = value; }
        public string Nombre { get => pNombre; set => pNombre = value; }
        public string NickName { get => pNickName; set => pNickName = value; }
        public byte[] Password_HASH { get => pPassword_HASH; set => pPassword_HASH = value; }
        public byte[] Password_SALT { get => pPassword_SALT; set => pPassword_SALT = value; }
        public DateTime FechCreacion { get => pFechCreacion; set => pFechCreacion = value; }
        public DateTime FechActualizacion { get => pFechActualizacion; set => pFechActualizacion = value; }
        public bool Activo { get => pActivo; set => pActivo = value; }
        #endregion
    }
}
