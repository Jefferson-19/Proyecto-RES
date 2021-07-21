using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RES.AccesoDatos;
namespace RES.LogicaNegocio
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */

    class ServicioSingleton
    {

        private ClsManejador _Manejador;
        private ServicioSingleton() 
        {
            _Manejador = new ClsManejador();
        }

        private static ServicioSingleton _Instancia;

        public ClsManejador Manejador { get => _Manejador; set => _Manejador = value; }

        public static ServicioSingleton GetInstance()
        {
            if (_Instancia == null)
            {
                _Instancia = new ServicioSingleton();
            }
            return _Instancia;
        }

    }
}
