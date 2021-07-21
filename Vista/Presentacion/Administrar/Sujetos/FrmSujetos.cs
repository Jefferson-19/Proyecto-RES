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
    public partial class FrmSujetos : Control_Principal_Vista
    {
       
        public FrmSujetos(): base()
        {
            InitializeComponent();
           
        }
        #region Overrride
        public override void BtnNuevo_Click(object sender, EventArgs e)
        {
            base.BtnNuevo_Click(sender, e);
            
                FrmAddSujetos Add = new FrmAddSujetos();
                Add.ShowDialog();
                Actualizar();
        }
        public override void BtnModificar_Click(object sender, EventArgs e)
        {
            base.BtnModificar_Click(sender, e);
            
                FrmModSujetos Upd = new FrmModSujetos();
                Upd.ShowDialog();
                Actualizar();
            
        }
        public override void BtnEliminar_Click(object sender, EventArgs e)
        {
            base.BtnEliminar_Click(sender, e);
           
                Actualizar();
            
        }
        public override void Actualizar()
        {
            base.Actualizar();
            
            this.BtnEliminar.Visible = true;
            this.CmbFiltro.Visible = false;
            this.LblFiltro.Visible = false;

            
        }
        
        #endregion
        public override void BtnRefresh_Click(object sender, EventArgs e)
        {
 	        base.BtnRefresh_Click(sender, e);
            Actualizar();
            this.CmbFiltro.Visible = false;
        }
        
        #region Funciones Privadas
          #endregion
    
        private void FrmSujetos_Load(object sender, EventArgs e)
        {
            Actualizar();
            this.CmbFiltro.Visible = false;
        }


    }
}
