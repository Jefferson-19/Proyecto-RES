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

    public class ClsManejador_Empleado:ClsManejadorBase<ClsDatosEmpleado>
    {

        public ClsManejador_Empleado()
        {
            Datos = new List<ClsDatosEmpleado>();
        }

        #region Metodos  Privados
        private Int32 GetNuevoID() 
        {
            if (Datos != null)
            {                
                Int32 newNumero = Datos.OrderByDescending(k => k.ID).FirstOrDefault().ID;
                return newNumero ++;
            }
            else 
            { 
                Datos = new List<ClsDatosEmpleado>();
                return 1;
            }
        }    
        
        #endregion  

        #region Metodos publicos

        //Método para insertar información
        public override void Insertar(List<ClsDatosEmpleado> lst)
        {
            try
            {
                if (lst != null)
                {
                    Datos.Add(new  ClsDatosEmpleado(GetNuevoID(), lst[0].IDUsuarioAdd, lst[0].IDUsuarioUpd, lst[0].IDDepartamento, lst[0].Documento, lst[0].Nombre, lst[0].Apellido, lst[0].Telefono, lst[0].Direccion, lst[0].Activo, lst[0].Foto, lst[0].FechaAdd, lst[0].FechaUpd, lst[0].Sueldo, lst[0].FechaEntrada, lst[0].FechaSalida));
                    
                }
            }
            catch (Exception ex)
            { throw ex; }

        }
        public override void Actualizar(List<ClsDatosEmpleado> lst)
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
                        Datos.Add(new ClsDatosEmpleado(lst[0].ID, lst[0].IDUsuarioAdd, lst[0].IDUsuarioUpd, lst[0].IDDepartamento, lst[0].Documento, lst[0].Nombre, lst[0].Apellido, lst[0].Telefono, lst[0].Direccion, lst[0].Activo, lst[0].Foto, lst[0].FechaAdd, lst[0].FechaUpd, lst[0].Sueldo, lst[0].FechaEntrada, lst[0].FechaSalida));

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        //Método para elminar información
        public override void Eliminar(List<ClsDatosEmpleado> lst)
        {
            try
            {
                if (lst != null)
                {
                    foreach (ClsDatosEmpleado item in Datos)
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
                     ID=usuario.ID,
                    IDUsuarioAdd = usuario.IDUsuarioAdd,
                    IDUsuarioUpd = usuario.IDUsuarioUpd,
                    IDDepartamento = usuario.IDDepartamento,
                    Documento = usuario.Documento,
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    Telefono = usuario.Telefono,
                    Direccion = usuario.Direccion,
                    Activo = usuario.Activo,
                    Foto = usuario.Foto,
                    FechaAdd = usuario.FechaAdd,
                    FechaUpd = usuario.FechaUpd,
                };

                lstusuario.Add(tmp);
            }
            return lstusuario;
        }

        
        #endregion
    }
}
