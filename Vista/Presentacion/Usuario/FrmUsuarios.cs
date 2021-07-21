using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class FrmUsuarios : Control_Principal_Vista
    {
        public FrmUsuarios(): base ()
        {
            InitializeComponent();
            this.Text = "S";
        }
        #region Overrride
        public override void BtnNuevo_Click(object sender, EventArgs e)
        {
          
                base.BtnNuevo_Click(sender, e);
                FrmAddUsuarios Add = new FrmAddUsuarios();
                Add.ShowDialog();
                Actualizar();
        }
        public override void BtnModificar_Click(object sender, EventArgs e)
        {
            base.BtnModificar_Click(sender, e);

            FrmModUsuarios Upd = new FrmModUsuarios();

                Upd.ShowDialog();
                Actualizar();
            
        }
        public override void BtnEliminar_Click(object sender, EventArgs e)
        {
        base.BtnEliminar_Click(sender, e);
    }
        public override void Actualizar()
        {

            base.Actualizar();

            
        }

        #endregion
        public override void BtnRefresh_Click(object sender, EventArgs e)
        {
            base.BtnRefresh_Click(sender, e);
            Actualizar();
           
        }
        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            Actualizar();
            this.CmbFiltro.Visible = false;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        
    }
}
