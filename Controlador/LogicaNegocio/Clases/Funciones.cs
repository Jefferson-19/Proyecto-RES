using System.Threading.Tasks;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Collections;
using System.ComponentModel;
using System.Management;

namespace RES.LogicaNegocio
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */

    public class Funciones
    {
    #region Metodos publicos
        public double CalcularHoras(double HoraInicio ,double  HoraFin , double NHorasBase  = 8) 
        {
            double Hora =0;
            if (HoraFin > HoraInicio )
                Hora = HoraFin - HoraInicio;    
            else
                Hora = (24 - HoraInicio) + HoraFin;
            if (Hora >= NHorasBase) 
                return   Hora - NHorasBase; 
            else 
                return 0; 
        }
        
        public double EquivalenciaHora( int ID_Hora ) 
        {
            switch (ID_Hora)
	        {
                case 0:
                    return 0.5;
                case 1 :
                    return 1;
                case 2:
                    return 1.5;
                   
                case 3:
                    return 2;
                   
                case 4:
                    return 2.5;
                   
                case 5:
                    return 3;
                   
                case 6:
                    return 3.5;
                   
                case 7:
                    return 4;
                   
                case 8:
                    return 4.5;
                   
                case 9:
                    return 5;
                   
                case 10:
                    return 5.5;
                   
                case 11:
                    return 6;
                   
                case 12:
                    return 6.5;
                   
                case 13:
                    return 7;
                   
                case 14:
                    return 7.5;
                   
                case 15:
                    return 8;
                   
                case 16:
                    return 8.5;
                   
                case 17:
                    return 9;
                   
                case 18:
                    return 9.5;
                   
                case 19:
                    return 10;
                   
                case 20:
                    return 10.5;
                   
                case 21:
                    return 11;
                   
                case 22:
                    return 11.5;
                   
                case 23:
                    return 12;
                   
                case 24:
                    return 12.5;
                   
                case 25:
                    return 13;
                   
                case 26:
                    return 13.5;
                   
                case 27:
                    return 14;
                   
                case 28:
                    return 14.5;
                   
                case 29:
                    return 15;
                   
                case 30:
                    return 15.5;
                   
                case 31:
                    return 16;
                   
                case 32:
                    return 16.5;
                   
                case 33:
                    return 17;
                   
                case 34:
                    return 17.5;
                   
                case 35:
                    return 18;
                   
                case 36:
                    return 18.5;
                   
                case 37:
                    return 19;
                   
                case 38:
                    return 19.5;
                   
                case 39:
                    return 20;
                   
                case 40:
                    return 20.5;
                   
                case 41:
                    return 21;
                   
                case 42:
                    return 21.5;
                   
                case 43:
                    return 22;
                   
                case 44:
                    return 22.5;
                   
                case 45:
                    return 23;
                   
                case 46:
                    return 23.5;
                   
                case 47:
                    return 24;
                   
		        default:
                    return 0;
               
	        }
        }
    #endregion
   
    }
}
