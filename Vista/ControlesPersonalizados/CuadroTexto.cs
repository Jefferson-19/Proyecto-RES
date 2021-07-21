using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace RES.FrontEnd.ControlesPersonalizado
{
     public class CuadroTexto:TextBox
    {
        #region Constructor
        public CuadroTexto()
        {
            wColorTextoVacio = Color.Gray;
            wTextoVacio = "<Descripcion>";
        }
        #endregion
        #region Campos Privados
        private string wTextoVacio;
        bool BNDTextoVacio = false;
        private Color wColorTextoVacio;
        #endregion
        #region Propiedades Publicas
        public string TextoVacio
        {
            get { return wTextoVacio; }
            set { wTextoVacio = value; }
        }
        [Category("Texto Vacio")]
        public Color ColorTextoVacio
        {
            get { return wColorTextoVacio; }
            set { wColorTextoVacio = value; }
        }
        #endregion
        #region Metodos privados
        private void VerificaTextoVacio()
        {
            if (this.Text.Length > 0)
                BNDTextoVacio = false;
            else
                BNDTextoVacio = true;

            this.SetStyle(ControlStyles.UserPaint, BNDTextoVacio);
            this.Refresh();
        }
        #endregion
        #region Metodos Re-escritos
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            VerificaTextoVacio();
        }
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            VerificaTextoVacio();
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            if (BNDTextoVacio)
                e.Graphics.DrawString(wTextoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(ColorTextoVacio), new Point(0, 0));
            else
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
            base.OnPaint(e);
        }
       
        #endregion
    }
}
