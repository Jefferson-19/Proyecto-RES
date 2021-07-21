using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RES.FrontEnd.ControlesPersonalizado
{
    using RES.LogicaNegocio;

    public class CuadroTextoRuc:CuadroTextoBase
    {
        #region Campos Privados
        bool wValida = false;
        #endregion
        #region Propiedades Publicas
        public bool Validacion
        {
            get { return wValida; }
        }
        #endregion
        #region Metodos Re-escritos
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            this.MaxLength = 13;
            if (this.Text.Length >= 13)
            {

                if (FuncionesGenericas.ComprobarRuc(this.Text.Trim()) == false)
                {
                    e.Handled = true;
                    wValida = true;
                    this.Text = string.Empty;
                    System.Windows.Forms.MessageBox.Show("Cédula Inválida...");
                }
                else
                {
                    e.Handled = false;
                    wValida = false;
                }
                e.Handled = true;
            }

        }
        #endregion
    }
}
