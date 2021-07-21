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
    public partial class Control_Lista : Form
    {
        public BindingSource wBindingSource;
        public Control_Lista(DataTable Tabla )
        {
            InitializeComponent();
            wBindingSource = new BindingSource();
            wBindingSource.DataSource =Tabla;
            this.DtVista.DataSource = wBindingSource;

        }
        public Control_Lista()
        {
            InitializeComponent();
        }
        public int Registro;
        private void Control_Lista_Load(object sender, EventArgs e)
        {

        }

        public virtual void DtVista_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Registro = e.RowIndex;
        }

        public virtual void BtnSelect_Click(object sender, EventArgs e)
        {

        }

        private void DtVista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        public virtual void DtVista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        public virtual void TxtBusq_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
