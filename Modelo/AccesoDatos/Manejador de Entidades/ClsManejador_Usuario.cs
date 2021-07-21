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
    public class ClsManejador_Usuario:ClsManejadorBase<ClsDatosUsuario>
    {

        public ClsManejador_Usuario()
        {
            Datos = new List<ClsDatosUsuario>();
        }

        #region Metodos  Privados
        private Int16 GetNuevoID() 
        {
            if (Datos != null)
            {                
                Int16 newNumero = Datos.OrderByDescending(k => k.ID).FirstOrDefault().ID;
                return newNumero ++;
            }
            else 
            { 
                Datos = new List<ClsDatosUsuario>();
                return 1;
            }
        }    
        
        #endregion  

        #region Metodos publicos

        //Método para insertar información
        public override void Insertar(List<ClsDatosUsuario> lst)
        {
            try
            {
                if (lst != null)
                {
                    Datos.Add(new  ClsDatosUsuario(GetNuevoID(), lst[0].IDPerfil, lst[0].Nombre, lst[0].NickName, lst[0].Password_HASH, lst[0].Password_SALT, lst[0].FechCreacion, lst[0].FechActualizacion, lst[0].Activo));                    
                }
            }
            catch (Exception ex)
            { throw ex; }

        }
        public override void Actualizar(List<ClsDatosUsuario> lst)
        {
            try
            {
                if (lst != null)
                {
                    //eliminamos registro que va ser actualizado
                    int respuesta= Datos.RemoveAll(P => P.ID==lst[0].ID);

                    //control de eliminacion 
                    if(respuesta >0)
                    { 
                        //se inserta el registro actualizado
                        Datos.Add(new ClsDatosUsuario(lst[0].ID, lst[0].IDPerfil, lst[0].Nombre, lst[0].NickName, lst[0].Password_HASH, lst[0].Password_SALT, lst[0].FechCreacion, lst[0].FechActualizacion, lst[0].Activo));
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        //Método para elminar información
        public override void Eliminar(List<ClsDatosUsuario> lst)
        {
            try
            {
                if (lst != null)
                {
                    foreach (ClsDatosUsuario item in Datos)
                    {
                        if (item.ID == lst[0].ID)
                        {
                            item.Activo = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            { throw ex; }

        }

        public override List<object> Listar()
        {
            List<Object> lstusuario = new List<Object>();

            foreach (var usuario in Datos)
            {
                var tmp = new
                {
                    ID =usuario.ID,
                    IDPerfil =usuario.IDPerfil,
                    Nombre =usuario.Nombre,
                    NickName =usuario.NickName,
                    Password_HASH =usuario.Password_HASH,
                    Password_SALT =usuario.Password_SALT,
                    FechCreacion =usuario.FechCreacion,
                    FechActualizacion =usuario.FechActualizacion,
                    Activo =usuario.Activo,
                };

                lstusuario.Add(tmp);
            }
            return lstusuario;
        }

        
        #endregion
    }
}
