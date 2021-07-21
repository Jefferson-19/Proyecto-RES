using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace RES.FrontEnd.ControlesPersonalizado
{
    using RES.LogicaNegocio;
    public class CuadroTextoCedula : CuadroTextoBase
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
            this.MaxLength = 10;
            if (this.Text.Length >= 10)
            {

                if (FuncionesGenericas.ComprobarCedula(this.Text.Trim()) == false)
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
