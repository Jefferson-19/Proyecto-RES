using System;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class FrmGrupos : Control_Principal_Vista
    {
        
        public FrmGrupos(): base()
        {
            InitializeComponent();
            
        }
        #region Overrride
        public override void BtnNuevo_Click(object sender, EventArgs e)
        {
            base.BtnNuevo_Click(sender, e);
           
            FrmAddGrupos Add = new FrmAddGrupos();
            Add.ShowDialog();
            Actualizar();
           
        }
        public override void BtnModificar_Click(object sender, EventArgs e)
        {         
                FrmModGrupos Upd = new FrmModGrupos();
                Upd.ShowDialog();
                Actualizar();
            
        }
        public override void Actualizar()
        {
            base.Actualizar();
            
            this.BtnEliminar.Visible = false;
            
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
        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            Actualizar();
            this.CmbFiltro.Visible = false;
        }

    }
}
