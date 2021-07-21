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
    public partial class Calcular_Horas : RES.FrontEnd.Control_Agregar_Pq
    {
        DateTime DiaActual;
        bool wTipo;
        
        BindingSource wBindigVista = new BindingSource();
        BindingSource wBindigHorasXDia = new BindingSource();
        BindingSource wBindigTimbradas = new BindingSource();

        Boolean wFiltVista, wFiltHora, wFiltTimb = false;
        public enum Tipo{Correccion, TimbradaManual}

        public Calcular_Horas()
            : base()
        {
            InitializeComponent();
           

            for (int i = DateTime.Now.Year-5 ; i <= DateTime.Now.Year; i++)
            {
                this.Cmb_Anio.Items.Add(i);
            }

            this.Cmb_Anio.Text = DateTime.Now.Year.ToString();


            this.Btn_Grabar.Text = "Refrescar";
            /*
            switch (Tipmodulo)
            {
                case Tipo.Correccion:
                    this.BtnCorregir.Image = global::RES.FrontEnd.Properties.Resources.table_row_delete;
                    this.BtnCorregir.Text = "Corregir";
                    wTipo = false;
                    break;
                case Tipo.TimbradaManual:
                    this.BtnCorregir.Image = global::RES.FrontEnd.Properties.Resources.tab_edit;
                    this.BtnCorregir.Text = "Timbrada Manual";
                    this.BtnCorregir.Enabled = true;
                    wTipo = true;
                    break;
                default:
                    break;
            }

            

            */
            
        }
        
        private void CmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.CmbFiltro.Text.ToString() != "System.Data.DataRowView")
            {
                if (!wTipo){this.BtnCorregir.Enabled = false;}

                if (wFiltVista)
                {
                    wBindigVista.Filter = "";
                    wBindigVista.Filter = string.Concat("Grupo like '%", this.CmbFiltro.Text.ToString(), "%'");
                    wFiltVista = false;
                }
                else
                {
                    wFiltVista = true;
                    wBindigVista.Filter = string.Concat("Grupo like '%", this.CmbFiltro.Text.ToString(), "%'");
                }
            }
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
           
        }
        #region  Validaciones
        void ValidarMes()
        {
            
            if (wFiltHora)
            {
                wFiltHora = false;
                
                this.DtTimbradas.Visible = false;
                if (!wTipo) { this.BtnCorregir.Enabled = false; }
            }
            else
            {
                wFiltHora = true;
             //this.DtHorasXDia.Columns["Mes"].Visible = false;
                this.DtTimbradas.Visible = false;
                if (!wTipo) { this.BtnCorregir.Enabled = false; }
            }
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
            //ValidarMes();
        }

        private void Calcular_Horas_Load(object sender, EventArgs e)
        {
            CargarTodo();
            //ValidarMes();
        }

        private void DtVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


    }
}
