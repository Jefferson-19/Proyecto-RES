using System;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class Calcular_Timbradas :Control_Agregar_Pq
    {
        
       

        public Calcular_Timbradas():base()
        {
            InitializeComponent();
           
           
        }
        
        private void CmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
       private void DtVista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DtHorasXDia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
       
              
        }
        private void Cmb_Mes_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarMes();
        }
        private void BtnCorregir_Click(object sender, EventArgs e)
        {           
                Correccion_Ticket FrmCorregir = new Correccion_Ticket();
                    FrmCorregir.ShowDialog();
         }
        #region  Validaciones
        void ValidarMes()
        {
         
        }
        void CargarTodo()
        {
            
            ValidarMes();
        }
        #endregion
        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {
            base.Btn_Grabar_Click(sender, e);
            CargarTodo();
        }

        private void Calcular_Horas_Load(object sender, EventArgs e)
        {
            CargarTodo();
        }

        private void DtVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Cmb_Anio_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarMes();
        }
    }
}