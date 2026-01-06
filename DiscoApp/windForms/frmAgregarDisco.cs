using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;


namespace DiscoAdoNet
{
    public partial class frmAgregarDisco : Form
    {
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                disco.Titulo = txtTitulo.Text;
                disco.CantidadCanciones = int.Parse(txtCantidadCanciones.Text);
                disco.UrlImagen = txtUrlImag.Text;

                negocio.agregarDisco(disco);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();

            try
            {
                comboBoxGenero.DataSource = discoNegocio.Listar();
                comboBoxTipo.DataSource = discoNegocio.Listar(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
