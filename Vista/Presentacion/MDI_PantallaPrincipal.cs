using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class MDI_PantallaPrincipal : Form
    {
       

        public MDI_PantallaPrincipal()
        {
            InitializeComponent();
        }
        private void MDIPrincipal2_Load(object sender, EventArgs e)
        {
            this.PanelSplit.Panel1Collapsed = false;
            this.PanelSplit.Panel1MinSize = 180;
            this.PanelSplit.Panel2MinSize = this.Width - this.PanelSplit.Panel1MinSize-5;

            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            if (Frm_Login.IsLogin == 1)
            {
               
               
                this.Tx.Text ="";
                this.CargarMenus();
            }
            else
            {
                Application.Exit();
            }  
        }

        private void CargarMenus()
        {
        }
        private void AgregarMenuHijo(ToolStripItem MenuItemPadre)
        {
            ToolStripMenuItem MenuPadre = (ToolStripMenuItem)MenuItemPadre;

            
        }
        private void MenuItemClicked(object sender, EventArgs e)
        {
            
            // if the sender is a ToolStripMenuItem
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
               
                string[] Formulario; 
                Formulario=((ToolStripItem)sender).Tag.ToString().Split('#');
                string NombreFormulario = Formulario[0];

              
            }
        }
        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            if (this.MdiChildren.Length > 0)
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name == NombreDelFrm.Substring(NombreDelFrm.IndexOf("Frm_"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm_")))
                    {
                        MessageBox.Show("El formulario solicitado ya se encuentra abierto");
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            int indice = tabMain.SelectedIndex;
            if (indice > 0) //no queremos cerrar nunca la inicial.
            {
                tabMain.TabPages.Remove(tabMain.SelectedTab);
                tabMain.SelectedIndex = indice - 1;
                GC.Collect();
            }
        }
        private int indicePestanaAbierta(String titulo)
        {
            Boolean enc = false;
            int i = 0;

            while ((i < tabMain.TabPages.Count) && (enc == false))
            {
                if (tabMain.TabPages[i].Text == titulo)
                    enc = true;
                else
                    i++;
            }
            if (enc)
                return i;
            else
                return -1;

        }
        private void nuevaPestana(Form  formHijo, String titulo)
        {
            int indice = indicePestanaAbierta(titulo);
            if (indice < 0)
            {

                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;                
                formHijo.Dock = DockStyle.Fill;
                
                formHijo.Show();

                TabPage tab = new TabPage();
                tab.Text = titulo;

                tab.Controls.Add(formHijo);
                
                tabMain.TabPages.Add(tab);
                tabMain.SelectedTab = tab;
            }
            else
            {
                //si ya existe vamos a limpiar el usercontrol y volverlo a cargar en la misma pestaña
                //   tabMain.TabPages[indice].Controls.Clear();
                //  tabMain.TabPages[indice].Controls.Add(formHijo);
                //  tabMain.SelectedTab = tabMain.TabPages[indice];
            }

        }

        private void MDI_PantallaPrincipal_Resize(object sender, EventArgs e)
        {
         //   this.PanelSplit.Panel1Collapsed = false;
          //  this.PanelSplit.Panel1MinSize = 180;
          //  this.PanelSplit.Panel2MinSize = this.Width - this.PanelSplit.Panel1MinSize ;
        }


       #region Botones
        private void BtnTim_AdminTim_Click(object sender, EventArgs e)
        {
            nuevaPestana(new FrmSujetos(), BtnTim_AdminTim.Text);
        }
        private void BtnTim_AdminRev_Click(object sender, EventArgs e)
        {
            nuevaPestana(new Calcular_Horas(), this.BtnTim_AdminRev.Text);
        }
        private void BtnTim_AdminMan_Click(object sender, EventArgs e)
        {
            nuevaPestana(new Calcular_Horas(), this.BtnTim_AdminMan.Text);
        }
        private void BtnTim_ReportListadoEmpleado_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnTim_ReportDetalle_Click(object sender, EventArgs e)
        {
           
        }
        private void BtnTim_ReportVista_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnTim_ReportResumen_Click(object sender, EventArgs e)
        {
            
        }
       
        private void BtnTic_ReportListadoCliente_Click(object sender, EventArgs e)
        {
          
        }
        private void BtnTic_ReportListadoEmpresas_Click(object sender, EventArgs e)
        {
         
        }
        private void BtnTic_ReportDetalleTicket_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnTic_ReportTicketGrupos_Click(object sender, EventArgs e)
        {
          
        }
       #endregion

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminUsuario_Click(object sender, EventArgs e)
        {
            nuevaPestana(new  FrmUsuarios(), this.BtnAdminUsuario.Text);
        }

       

        

       

        

        
       

        

     

        
       
    }
}
