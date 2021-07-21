using System;
using System.Data;
using System.Windows.Forms;

namespace RES.FrontEnd
{

    public partial class FrmModSujetos : Control_Agregar_Pq
    {
       
        public FrmModSujetos():base()
        {
            InitializeComponent();
           
        }
        private void FrmAddSujetos_Load(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TxtBarcode_TextChanged(object sender, EventArgs e)
        {


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void TxtCard_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
        private void CmbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void TxtCard_Click(object sender, EventArgs e)
        {
        }
        private void TxtBarcode_Click(object sender, EventArgs e)
        {
        }
        private bool Comprobar()
        {


            if (string.IsNullOrEmpty(this.TxtApellidoSujeto.Text))
            {
                this.InformarError.SetError(TxtApellidoSujeto, "Falta de llenar el campo!");
                return false;
            }

            if (string.IsNullOrEmpty(this.TxtNombreSujeto.Text))
            {
                this.InformarError.SetError(TxtNombreSujeto, "Falta de llenar el campo!");
                return false;
            }

            if (string.IsNullOrEmpty(this.TxtCedula.Text))
            {
                this.InformarError.SetError(TxtCedula, "Falta de llenar el campo!");
                return false;
            }

            if (this.TxtCedula.Text.Length < 10)
            {
                this.InformarError.SetError(TxtCedula, "Campo debe ser mayor a 10 digítos!");
                return false;
            }



            return true;

        }
        #region Override
        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {
            base.Btn_Grabar_Click(sender, e);
            
        }
        #endregion

        private void PicImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg"; //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Buscador de Imágenes";
            BuscarImagen.InitialDirectory = "C:\\";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
             
                PicImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

           
        }

        private void PictureLectura_Click(object sender, EventArgs e)
        {
          
           
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
        void DisplayError(string funcName, int iError)
        {
           
        }
    }
}