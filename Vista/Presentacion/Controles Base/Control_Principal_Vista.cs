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
    public  partial class Control_Principal_Vista : Form
    {
        
        public Control_Principal_Vista()
        {
            InitializeComponent();
         
        }
        
       
        #region MetodosPrivados y Constructor
       
        #endregion
        
        public virtual void BtnNuevo_Click(object sender, EventArgs e)
        {
            

        }

        public virtual void BtnModificar_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void Control_Principal_Vista_Load(object sender, EventArgs e)
        {

            Actualizar();

        }

        public virtual void DtVista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        public virtual void Actualizar()
        {
            
            this.DtVista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DtVista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
             this.DtVista.MultiSelect = false;
        }
        public virtual void BtnRefresh_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public virtual void CmbFiltro_Click(object sender, EventArgs e)
        {

        }

        public virtual void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MnuImagen_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DtVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public virtual void DtVista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        public virtual void DtVista_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public virtual void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void DtVista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public virtual void BtnOpcion_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnOpcion2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
