using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RES.AccesoDatos;

namespace RES.LogicaNegocio
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */
    public class Usuario : CastObjetos<ClsDatosUsuario>, ICRUD
    {
        ClsManejador M = ServicioSingleton.GetInstance().Manejador;

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
        public Usuario(){ }
        public Usuario(Int16 _ID, Perfiles _IDPerfil, string _Nombre, string _NickName, string _Password,  DateTime _FechCreacion, DateTime _FechActualizacion, bool _Activo)
        {
            pID = _ID;
            pIDPerfil = _IDPerfil;
            pNombre = _Nombre;
            pNickName = _NickName;
            EncriptarPassword(_Password,out pPassword_HASH,out pPassword_SALT);
            pFechCreacion = _FechCreacion;
            pFechActualizacion = _FechActualizacion;
            pActivo = _Activo;
        }
        #endregion

        #region Propiedades publicas
        public Int16 ID { get => pID; set => pID = value; }
        public Perfiles IDPerfil { get => pIDPerfil; set => pIDPerfil = value; }
        public string Nombre { get => pNombre; set => pNombre = value; }
        public string NickName { get => pNickName; set => pNickName = value; }
        public DateTime FechCreacion { get => pFechCreacion; set => pFechCreacion = value; }
        public DateTime FechActualizacion { get => pFechActualizacion; set => pFechActualizacion = value; }
        public bool Activo { get => pActivo; set => pActivo = value; }

        //Metodo Registrar 
        public String Registrar()
        {
            string msj = "";

            //Lista generica de parametros
            List<ClsDatosUsuario> lst = new List<ClsDatosUsuario>();
            try
            {

                // Busqueda del registro para actualizar
                var Buscar = BuscarPorID(pID);
                if (Buscar != null) { throw new Exception("Se encontro registros"); }
                if (Buscar.Count >= 1) { throw new Exception("Se encontro registros"); }


                //Pasar los parametros hacia la capa de acceso a datos
                lst.Add(new ClsDatosUsuario(pID, pIDPerfil, pNombre, pNickName, pPassword_HASH, pPassword_SALT, pFechCreacion, pFechActualizacion, pActivo));
                M.Usuario.Insertar(lst);
                msj = "Insertado correctamente";
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }
            return msj;
        }

        //Metodo Eliminar 
        public String Eliminar()
        {
            string msj = "";

            //Lista generica de parametros
            List<ClsDatosUsuario> lst = new List<ClsDatosUsuario>();
            try
            {
                var Buscar = BuscarPorID(pID);
                if (Buscar == null) { throw new Exception("No se encontro registros"); }
                if (Buscar.Count >= 1)
                {
                    //Pasar los parametros hacia la capa de acceso a datos
                    lst.Add(new ClsDatosUsuario(pID));
                    M.Usuario.Eliminar(lst);
                    msj = "Eliminado correctamente";
                }
                else { throw new Exception("No se encontro registros"); }                
            }
            catch (Exception ex)
            {
                msj = "Error al eliminar los datos";
                return msj;
                throw ex;
            }
            return msj;
        }
        //Metodo Actualizar
        public string Actualizar()
        {
            string msj = "";

            //Lista generica de parametros
            List<ClsDatosUsuario> lst = new List<ClsDatosUsuario>();
            try
            {
                var Buscar = BuscarPorID(pID);
                if (Buscar == null) { throw new Exception("No se encontro registros"); }
                if (Buscar.Count >= 1)
                {
                    ClsDatosUsuario param = new ClsDatosUsuario();
                    param = ObjectCastToEntidad(Buscar[0]);

                    if (param.IDPerfil != pIDPerfil) { param.IDPerfil = pIDPerfil; }
                    if (param.NickName != pNickName) { param.NickName = pNickName; }
                    if (param.Nombre != pNombre) { param.Nombre = pNombre; }
                    if (param.Password_HASH != pPassword_HASH) { param.Password_HASH = pPassword_HASH; }
                    if (param.Password_SALT != pPassword_SALT) { param.Password_SALT = pPassword_SALT; }
                    if (param.FechCreacion != pFechCreacion) { param.FechCreacion = pFechCreacion; }
                    if (param.FechActualizacion != pFechActualizacion) { param.FechActualizacion = pFechActualizacion; }
                    if (param.Activo != pActivo) { param.Activo = pActivo; }

                    //Pasar los parametros hacia la capa de acceso a datos
                    lst.Add(param);
                    M.Usuario.Actualizar(lst);
                    msj = "Actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                msj = "Error al eliminar los datos";
                return msj;
                throw ex;
            }
            return msj;
        }

        public List<Object> GetListado()
        {
            return M.Usuario.Listar().Cast<Object>().ToList();
        }
        public List<Object> BuscarPorID(int ID)
        {
            try
            {
                List<Object> Retorno = new List<Object>();
                List<Object> Listado = M.Usuario.Listar();
                foreach (var usuario in Listado)
                {
                    System.Type type = usuario.GetType();

                    Int16 identificador = (Int16)type.GetProperty("ID").GetValue(usuario);
                    if (identificador == ID)
                    {
                       Retorno.Add(usuario);
                    }
                }
                return Retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Object> BuscarPorNickName(string NICKNAME)
        {
            try
            {
                List<Object> Retorno = new List<Object>();
                List<Object> Listado = M.Usuario.Listar();
                foreach (var usuario in Listado)
                {
                    System.Type type = usuario.GetType();

                    string _NickName = (string)type.GetProperty("NickName").GetValue(usuario);
                    if (_NickName.Trim().ToUpper() == NICKNAME.Trim().ToUpper())
                    {
                        Retorno.Add(usuario);
                    }
                }
                return Retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool VerificarAcceso(string _NickName, string _Password ) 
        {
            try
            {
                List<object> Buscar = BuscarPorNickName(_NickName);
                if (Buscar == null) { throw new Exception("No se encontro registros"); }
                if (Buscar.Count >= 1)
                {
                    System.Type type = Buscar[0].GetType();

                    byte[] _Password_HASH = (byte[])type.GetProperty("Password_HASH").GetValue(Buscar[0]);
                    byte[] _Password_SALT = (byte[])type.GetProperty("Password_SALT").GetValue(Buscar[0]);


                    if (!VerificarPassword(_Password, _Password_HASH, _Password_SALT)) { return false; }
                    else { return true; }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public string CambiarPassword(string _PasswordAnterior, string _PasswordNuevo)
        {

            try
            {
                List<object> Buscar = BuscarPorID(pID);
                if (Buscar == null) { throw new Exception("No se encontro registros"); }
                if (Buscar.Count >= 1)
                {
                    System.Type type = Buscar[0].GetType();

                    byte[] _Password_HASH = (byte[])type.GetProperty("Password_HASH").GetValue(Buscar[0]);
                    byte[] _Password_SALT = (byte[])type.GetProperty("Password_SALT").GetValue(Buscar[0]);


                    if (!VerificarPassword(_PasswordAnterior, _Password_HASH, _Password_SALT)) { return "Password anterior no corresponde!"; }
                    else 
                    {
                        EncriptarPassword(_PasswordNuevo, out byte[] passwordHASH, out byte[] passwordSALT);
                        return Actualizar();
                    }
                }

            }
            catch (Exception ex)
            {
                return "Error al cambiar password";
                throw ex;
            }
            return "Error al cambiar password";
        }
        private bool VerificarPassword(string password, byte[] passwordHASH, byte[] passwordSalt)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt);
            var passwordHASHnuevo = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return new ReadOnlySpan<byte>(passwordHASH).SequenceEqual(new ReadOnlySpan<byte>(passwordHASHnuevo));
        }
        private void EncriptarPassword(string password, out byte[] pHASH, out byte[] pSALT)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
            pSALT = hmac.Key;
            pHASH = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
                
        protected override ClsDatosUsuario ObjectCastToEntidad(object obj)
        {
            try
            {
                ClsDatosUsuario tmp = new ClsDatosUsuario();
                System.Type type = obj.GetType();

                tmp.ID = (Int16)type.GetProperty("ID").GetValue(obj);
                tmp.IDPerfil = (Perfiles)type.GetProperty("IDPerfil").GetValue(obj);
                tmp.Nombre = (string)type.GetProperty("Nombre").GetValue(obj);
                tmp.NickName = (string)type.GetProperty("NickName").GetValue(obj);
                tmp.Password_HASH = (byte[])type.GetProperty("Password_HASH").GetValue(obj);
                tmp.Password_SALT = (byte[])type.GetProperty("Password_SALT").GetValue(obj);
                tmp.FechCreacion = (DateTime)type.GetProperty("FechCreacion").GetValue(obj);
                tmp.FechActualizacion = (DateTime)type.GetProperty("FechActualizacion").GetValue(obj);
                tmp.Activo = (bool)type.GetProperty("Activo").GetValue(obj);

                return tmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override List<ClsDatosUsuario> ObjectCastToListEntidad(List<object> obj)
        {

            try
            {
                List<ClsDatosUsuario> tmp = new List<ClsDatosUsuario>();
                foreach (var item in obj)
                {
                    tmp.Add(ObjectCastToEntidad(item));
                }

                return tmp;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        #endregion


    }
}