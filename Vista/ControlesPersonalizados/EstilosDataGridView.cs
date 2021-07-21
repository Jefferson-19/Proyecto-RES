using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RES.FrontEnd.ControlesPersonalizado
{
    public class EstilosDataGridView
    {
        public static DataGridViewCellStyle StyleCuerpo(TiposCuerpoEstilos Stilo)
        {
            DataGridViewCellStyle styEstilo = new DataGridViewCellStyle();
            switch (Stilo)
            {
                case TiposCuerpoEstilos.Khaki_LightYellow:
                    styEstilo.BackColor = Color.LightYellow;
                    styEstilo.ForeColor = Color.DimGray;
                    styEstilo.Font = new Font("Verdana", 7, FontStyle.Regular);
                    styEstilo.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    styEstilo.NullValue = "--";
                    styEstilo.SelectionBackColor = Color.Khaki;
                    styEstilo.SelectionForeColor = Color.Black;
                    styEstilo.WrapMode = DataGridViewTriState.False;
                    break;
                case TiposCuerpoEstilos.Honeydew_Aquamarine:
                    styEstilo.BackColor = Color.Honeydew;
                    styEstilo.ForeColor = Color.SlateGray;
                    styEstilo.Font = new Font("Verdana", 7, FontStyle.Regular);
                    styEstilo.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    styEstilo.NullValue = "--";
                    styEstilo.SelectionBackColor = Color.Aquamarine;
                    styEstilo.SelectionForeColor = Color.Black;
                    styEstilo.WrapMode = DataGridViewTriState.False;
                    break;
                case TiposCuerpoEstilos.MediumSlateBlue_MistyRose:
                    styEstilo.BackColor = Color.MistyRose;
                    styEstilo.ForeColor = Color.DimGray;
                    styEstilo.Font = new Font("Verdana", 7, FontStyle.Regular);
                    styEstilo.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    styEstilo.NullValue = "--";
                    styEstilo.SelectionBackColor = Color.MediumSlateBlue;
                    styEstilo.SelectionForeColor = Color.White;
                    styEstilo.WrapMode = DataGridViewTriState.False;
                    break;
                default:
                    break;
            }
            return styEstilo;
        }
        /*public static DataGridViewCellStyle StyleCabecera(TiposCabeceraEstilos Stilo)
        {
            DataGridViewCellStyle styEstiloHeader = new DataGridViewCellStyle();
            switch (Stilo)
            {
                case TiposCabeceraEstilos.DarkGoldenrod:
                    styEstiloHeader.BackColor = Color.DarkGoldenrod;
                    styEstiloHeader.ForeColor = Color.Black;
                    styEstiloHeader.Font = new Font("Bradley Hand ITC", 8, FontStyle.Bold);
                    styEstiloHeader.Alignment = DataGridViewContentAlignment.BottomRight;
                    break;
                default:
                    break;
            }
            return styEstiloHeader;
        }*/
        public static DataGridViewCellStyle StyleCellTexto()
        {
            DataGridViewCellStyle styleTexto = new DataGridViewCellStyle();
            styleTexto.Alignment = DataGridViewContentAlignment.MiddleLeft;
            styleTexto.NullValue = "--";
            styleTexto.WrapMode = DataGridViewTriState.False;
            return styleTexto;
        }
        public static DataGridViewCellStyle StyleCellFecha()
        {
            DataGridViewCellStyle styleFEcha = new DataGridViewCellStyle();
            styleFEcha.Format = "dd/MM/yyyy";
            styleFEcha.NullValue = "Sin Fecha";
            styleFEcha.Alignment = DataGridViewContentAlignment.MiddleRight;
            return styleFEcha;
        }
        
        public static DataGridViewCellStyle StyleCellHora()
        {
            DataGridViewCellStyle styleFEcha = new DataGridViewCellStyle();
            //styleFEcha.Format = "hh:mm tt";
            styleFEcha.NullValue = "Sin Hora";
            styleFEcha.Alignment = DataGridViewContentAlignment.MiddleRight;
            return styleFEcha;
        }
        public static DataGridViewCellStyle StyleCellMes()
        {
            DataGridViewCellStyle styleFEcha = new DataGridViewCellStyle();
            styleFEcha.Format = "MMMM";
            styleFEcha.NullValue = "Sin Fecha";
            styleFEcha.Alignment = DataGridViewContentAlignment.MiddleRight;
            return styleFEcha;
        }
        public static DataGridViewCellStyle StyleCellInt()
        {
            DataGridViewCellStyle styleInt = new DataGridViewCellStyle();
            styleInt.NullValue = "0";
            styleInt.Alignment = DataGridViewContentAlignment.MiddleRight;
            return styleInt;
        }
        public static DataGridViewCellStyle StyleCellDecimal()
        {
            DataGridViewCellStyle styleDec = new DataGridViewCellStyle();
            styleDec.Format = "#,#.#0";
            styleDec.NullValue = "0";
            styleDec.Alignment = DataGridViewContentAlignment.MiddleRight;
            return styleDec;
        }
        public static DataGridViewCellStyle StyleCellMoneda()
        {
            DataGridViewCellStyle styleDec = new DataGridViewCellStyle();
            styleDec.Format = "$#,#.#0";
            styleDec.NullValue = "0";
            styleDec.Alignment = DataGridViewContentAlignment.MiddleRight;
            return styleDec;
        }
        public enum TiposCuerpoEstilos { Khaki_LightYellow, Honeydew_Aquamarine, MediumSlateBlue_MistyRose }
        /*public enum TiposCabeceraEstilos { DarkGoldenrod }*/
    }
}
