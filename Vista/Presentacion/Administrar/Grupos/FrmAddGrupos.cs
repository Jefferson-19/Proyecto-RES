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
    public partial class FrmAddGrupos :Control_Agregar_Pq
    {
        public FrmAddGrupos(): base()
        {
            InitializeComponent();
        }
        
        #region Override
        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {
            base.Btn_Grabar_Click(sender, e);
            
                
                MessageBox.Show("Datos Grabados con Exito!");
                this.Close();
         
        }
        #endregion

        private void FrmAddGrupos_Load(object sender, EventArgs e)
        {

        }

        private void CmbTipoGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
