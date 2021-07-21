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
    public class ClsDatosPersona
    {
        Int32 pID;
        Int16 pIDUsuarioAdd;
        Int16 pIDUsuarioUpd;
        Int16 pIDDepartamento;
        string pDocumento;
        string pNombre;
        string pApellido;
        string pTelefono;
        string pDireccion;
        bool pActivo;
        byte[] pFoto;
        DateTime pFechaAdd;
        DateTime pFechaUpd;

        #region Constructor
        public ClsDatosPersona()
        {

        }
        public ClsDatosPersona(Int32 _ID)
        {
            pID = _ID;
        }

        public ClsDatosPersona(Int32 _ID, Int16 _IDUsuarioAdd, Int16 _IDUsuarioUpd, Int16 _IDDepartamento, string _Documento, string _Nombre, string _Apellido, string _Telefono, string _Direccion, bool _Activo, byte[] _Foto, DateTime _FechaAdd, DateTime _FechaUpd)
        {
            pID = _ID;
            pIDUsuarioAdd = _IDUsuarioAdd;
            pIDUsuarioUpd = _IDUsuarioUpd;
            pIDDepartamento = _IDDepartamento;
            pDocumento = _Documento;
            pNombre = _Nombre;
            pApellido = _Apellido;
            pTelefono = _Telefono;
            pDireccion = _Direccion;
            pActivo = _Activo;
            pFoto = _Foto;
            pFechaAdd = _FechaAdd;
            pFechaUpd = _FechaUpd;
            pActivo = _Activo;
        }

        #endregion
        #region Propiedades publicas

        public Int32 ID
        {
            get { return pID; }
            set { pID = value; }
        }
        public Int16 IDUsuarioAdd
        {
            get { return pIDUsuarioAdd; }
            set { pIDUsuarioAdd = value; }
        }
        public Int16 IDUsuarioUpd
        {
            get { return pIDUsuarioUpd; }
            set { pIDUsuarioUpd = value; }
        }
        public Int16 IDDepartamento
        {
            get { return pIDDepartamento; }
            set { pIDDepartamento = value; }
        }
        public DateTime FechaAdd
        {
            get { return pFechaAdd; }
            set { pFechaAdd = value; }
        }
        public DateTime FechaUpd
        {
            get { return pFechaUpd; }
            set { pFechaUpd = value; }
        }
        public bool Activo
        {
            get { return pActivo; }
            set { pActivo = value; }
        }
        public string Documento
        {
            get { return pDocumento; }
            set { pDocumento = value; }
        }
        public byte[] Foto
        {
            get { return pFoto; }
            set { pFoto = value; }
        }
        public string Nombre
        {
            get { return pNombre; }
            set { pNombre = value; }
        }
        public string Apellido
        {
            get { return pApellido; }
            set { pApellido = value; }
        }
        public string Telefono
        {
            get { return pTelefono; }
            set { pTelefono = value; }
        }
        public string Direccion
        {
            get { return pDireccion; }
            set { pDireccion = value; }
        }
        #endregion
    }
}
