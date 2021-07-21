using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace RES.LogicaNegocio
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */
    public class FuncionesGenericas 
    {
        #region Campos publicos
        #endregion

        #region Campos Privados
        #endregion

        #region Metodos publicos
            public static string DesConvertir(string Numero, int Base)
        {
            string[] Resul = Numero.Split(new Char[] { ' ' });
            int posicion;
            string Sum = "";
            int Mul = 0;
            int wposicion;
            posicion = Resul.Count() - 1;
            wposicion = posicion;
            for (int i = 0; i < posicion; i++)
            {
                Mul = Convert.ToInt32(Resul[wposicion]) * (Base ^ i);
                Sum = string.Concat(Sum, Mul);
                wposicion = wposicion - 1;
            }
            return Sum;
        }
            public static string Convertir(int Numero, int Base)
        {
            string resul = "";
            int b = 0, i = 0;
            try
            {
                switch (Base)
                {
                    case 2:
                        
                        while (Numero >= 2)
                        {
                            
                            b = Numero % 2;
                            Numero = Numero / 2;
                            resul = string.Concat(" ", b, resul);
                            i++;
                        }
                        resul = string.Concat(" ", 1, resul);
                        break;
                    case 7:
                    Ini7: if (Numero > Base - 1)
                        {
                            b = Numero % 2;
                            Numero = Numero / 2;
                            resul = string.Concat(" ", b, resul);
                            i++;
                            goto Ini7;
                        }
                        else
                        {
                            resul = string.Concat(" ", b, resul);
                            i++;
                        }
                        for (int length = i; length < 11; length++)
                        {
                            resul = string.Concat(" ", 0, resul);
                        }
                        break;
                    case 5:
                    Ini5:
                        if (Numero > Base - 1)
                        {
                            b = Numero % 2;
                            Numero = Numero / 2;
                            resul = string.Concat(" ", b, resul);
                            i++;
                            goto Ini5;
                        }
                        else
                        {
                            resul = string.Concat(" ", b, resul);
                            i++;
                        }
                        for (int length = i; length < 5; length++)
                        {
                            resul = string.Concat(" ", 0, resul);
                        }
                        break;
                    default:
                    IniDefault:
                        if (Numero > Base - 1)
                        {
                            b = Numero % 2;
                            Numero = Numero / 2;
                            resul = string.Concat(" ", b, resul);
                            i++;
                            goto IniDefault;
                        }
                        else
                        {
                            resul = string.Concat(" ", b, resul);
                            i++;
                        }
                        for (int length = i; length < 11; length++)
                        {
                            resul = string.Concat(" ", 0, resul);
                        }
                        break;
                }
            }
            catch (Exception)
            {
                // global::System.Windows.Forms.MessageBox.Show(ex.ToString);
                throw;
            }
            return resul.Trim();
        }
            public static char Chr(byte src)
        {
            return (System.Text.Encoding.GetEncoding("iso-8859-1").GetChars(new byte[] { src })[0]);
        }
            public static byte Asc(char src)
        {
            return (System.Text.Encoding.GetEncoding("iso-8859-1").GetBytes(src +
            "")[0]);
        }
            public static string ExcelNumeroHora(double NumeroHora)
        {
                double wHora= Math.Truncate(NumeroHora * 24);
                double wMinutos =Math.Truncate(((NumeroHora * 24)-wHora)*60);
                double wSegundos = Math.Truncate(((((NumeroHora * 24) - wHora) * 60)-wMinutos)*60);
                return string.Format("{0:00}:{1:00}:{2:00}", wHora, wMinutos, wSegundos);


                    /* codigo viejo
            double wHora = 0;
            double wMinutos = 0;
            double wFacH, wFacM;
            double WRestFacM, WRestFacS;
            const double MinutisCons = 0.0416666666666667;



            wHora = Math.Truncate(NumeroHora * 24);
            wFacH = wHora / 24;



            if (wFacH > NumeroHora) { WRestFacM = wFacH - NumeroHora; }
            else { WRestFacM = NumeroHora - wFacH; }
            if (WRestFacM != 0)
            {
                wMinutos = Math.Truncate((WRestFacM * 60) / MinutisCons);
                wFacM = (wMinutos * MinutisCons) / 60;
                if (wFacM > ((WRestFacM * 60) / MinutisCons)) { WRestFacS = wFacM - ((WRestFacM * 60) / MinutisCons); }
                else { WRestFacS = ((WRestFacM * 60) / MinutisCons) - wFacH; }
            }
            return string.Concat(wHora, ":", wMinutos, ":00");
                     */
        }
            public static double ExcelStringHora(string StringHora)
        {
            string[] wHoraT = StringHora.Split(new Char[] { ':' });
            int wHora = Convert.ToInt32(wHoraT[0]);
            int wMinutos = Convert.ToInt32(wHoraT[1]);
            double wFacM;
            double MinutisCons =Convert.ToDouble( wHoraT[2]) / 60 ;
            wFacM = (wMinutos + MinutisCons) / 60;
            return (wHora+wFacM) / 24;
        }
            public static int MesInteger(string MounthString)
        {
            int wRETURN = 0;
            switch (MounthString.ToUpper())
            {
                case "ENERO":
                    wRETURN = 1;
                    break;
                case "FEBRERO":
                    wRETURN = 2;
                    break;
                case "MARZO":
                    wRETURN = 3;
                    break;
                case "ABRIL":
                    wRETURN = 4;
                    break;
                case "MAYO":
                    wRETURN = 5;
                    break;
                case "JUNIO":
                    wRETURN = 6;
                    break;
                case "JULIO":
                    wRETURN = 7;
                    break;
                case "AGOSTO":
                    wRETURN = 8;
                    break;
                case "SEPTIEMBRE":
                    wRETURN = 9;
                    break;
                case "OCTUBRE":
                    wRETURN = 10;
                    break;
                case "NOVIEMBRE":
                    wRETURN = 11;
                    break;
                case "DICIEMBRE":
                    wRETURN = 12;
                    break;
                default:
                    wRETURN = 0;
                    break;
            }
            return wRETURN;
        }
            public static double Porcentaje(double VALOR1, double VALOR2)
        {
            double POR;
            POR = (VALOR1 * VALOR2) / 100;
            return POR;
        }
            public static bool ComprobarRuc(string Ruc) 
        {
           bool retorno=false;
            string [] Cadena = new string[13];
            if (Ruc != "")
            {
                for (int i = 0; i < 13; i++) { Cadena[i] = Ruc.Substring(i, 1);  }
                switch (Ruc.Length)
                {
                    case 10:
                        if (Cod_Ciudad(Convert.ToInt32(string.Concat(Cadena[0], Cadena[1]))))
                        { if (Pnutural(Cadena) || Juridica(Cadena)) retorno = true; }
                        break;
                    case 13:
                        if (Cod_Ciudad(Convert.ToInt32(string.Concat(Cadena[0], Cadena[1]))) && Cod_Esta(Convert.ToInt32(string.Concat(Cadena[10], Cadena[11], Cadena[12]))))
                        { if (Pnutural(Cadena) || Juridica(Cadena)) retorno = true; }
                        break;
                    default:
                        break;
                }
            }
                    return retorno;
       }
            public static bool ComprobarCedula(string CEDULA)
   {
      
       bool Retorno=false;
       string [] Cadena= new string[10];
       int Cod_Ciudad, Sum_Pares;
        int Suma_Total, Digito_verificador ;
        int aux, Sum_Impares=0;
       for (int i = 0; i <10 ; i++)
			{
			Cadena[i] = CEDULA.Substring( i, 1); 
			}
        Cod_Ciudad = Convert.ToInt32(string.Concat(Cadena[0] , Cadena[1]));
       if (Cod_Ciudad <= 24 && Cod_Ciudad != 0)
	{
           int J = 0;
           for (int i = 0; i < 5; i++)
			{
			    aux = Convert.ToInt32( Cadena[J]) * 2;
               if( aux > 9 ) aux = aux - 9;
                Sum_Impares = Sum_Impares + aux;
                aux = 0;
                J = J + 2;
			}
            //SUMA DE PARES
            Sum_Pares = Convert.ToInt32(Cadena[1]) + Convert.ToInt32(Cadena[3]) + Convert.ToInt32(Cadena[5]) + Convert.ToInt32(Cadena[7]);
            Suma_Total = Sum_Pares + Sum_Impares;
            Digito_verificador = SetDecenaSuperior(Suma_Total) - Suma_Total;
            if (Digito_verificador == 10){Digito_verificador = 0;}
            if (Digito_verificador == Convert.ToInt32 (Cadena[9])){Retorno= true;}        
       }
        else
       {
            Retorno = false;
       }    
        return Retorno;
    }
            public bool ComprobarIP(string ValorIP)
        {
            bool Q = false;
            string[] cadena = ValorIP.Split(new Char[] { '.' });
            if (cadena.GetUpperBound(0) == 3)
            {
                int result;
                for (int i = 0; i < 3; i++) { if (int.TryParse(cadena[i], out result)) { Q = true; } }
            }
            return Q;
        }
            
        #endregion

        #region Metodos Privados
            static int ValidarCoeficiente(int Numero)
            {
                string[] NUM = new string[2];
                if ((Numero >= 0) && (Numero <= 9)) { return Numero; }
                else
                {
                    NUM[0] = Convert.ToString(Numero).Substring(0, 1);
                    NUM[1] = Convert.ToString(Numero).Substring(1, 1);
                    return (Convert.ToInt32(NUM[0]) + Convert.ToInt32(NUM[1]));
                }
            }
            static bool Juridica(string[] Digitos)
        {
            int[] vNueve = new int[] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int[] vSeis = new int[] { 3, 2, 7, 6, 5, 4, 3, 2 };
            int Digito_verifi = 0;
            int Wscoe = 0;
            bool Retornar = false;
            switch (Convert.ToInt32(Digitos[2]))
            {
                case 6:
                    for (int i = 0; i < 9; i++) { Wscoe = Wscoe + (Convert.ToInt32(Digitos[i]) * vSeis[i]); }
                    if ((Wscoe % 11) != 0) { Digito_verifi = 11 - (Wscoe % 11); }
                    else { Digito_verifi = (Wscoe % 11); }
                    if (Digito_verifi == Convert.ToInt32(Digitos[8])) { Retornar = true; }
                    break;
                case 9:
                    for (int i = 0; i < 9; i++) { Wscoe = Wscoe + (Convert.ToInt32(Digitos[i]) * vNueve[i]); }
                    if ((Wscoe % 11) != 0) { Digito_verifi = 11 - (Wscoe % 11); }
                    else { Digito_verifi = (Wscoe % 11); }
                    if (Digito_verifi == Convert.ToInt32(Digitos[9])) { Retornar = true; }
                    break;
            }
            return Retornar;
        }
            static bool Pnutural(string[] Digitos)
        {
            int [] Vector= new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2};
            int Digito_verifi=0;
            int Wscoe=0;
            bool Pnutural = false;
            if ((Convert.ToInt32(Digitos[2]) >= 0) && (Convert.ToInt32(Digitos[2]) <= 5))
            {
                for (int i=0; i < 9; i++){Wscoe = Wscoe + ValidarCoeficiente(Convert.ToInt32(Digitos[i]) * Convert.ToInt32(Digitos[i]));}
            }
            if ((Wscoe % 10) == 0) Digito_verifi = (Wscoe % 10); 
            else  Digito_verifi = 10 - (Wscoe % 10);
            if (Digito_verifi == Convert.ToInt32(Digitos[9])) Pnutural = true; 
            return Pnutural;
        }
            static bool Cod_Ciudad(int Valor)
        {
            if ((Valor >= 1) && (Valor <= 24))  return true; 
            else  return false; 
        }
            static bool Cod_Esta(int Valor)
        {
            if (Valor >= 1)  return true; 
            else  return false; 
        }
            static int SetDecenaSuperior(int Num)
        {
            string [] NUMERO= new string[2];
            string N = Convert.ToString(Num);
            NUMERO[0] = N.Substring( 0, 1);
            NUMERO[1] =  N.Substring( 1, 1);
            return Convert.ToInt32(string.Concat(Convert.ToInt32(NUMERO[0]) + 1, '0'));
        }
        #endregion
    }
}
   
       

       
     

     
