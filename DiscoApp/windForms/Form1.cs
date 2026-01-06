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
    public partial class DiscoForm1 : Form
    {
        private List<Disco> listaDisco;
        public DiscoForm1()
        {
            InitializeComponent();
        }
        private void DiscoForm1_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.Listar();
            dgvDisco.DataSource = listaDisco;
            dgvDisco.Columns["UrlImagen"].Visible = false;
            CargarImagen(listaDisco[0].UrlImagen);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            Disco Seleccionado = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.UrlImagen);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pcbImagenDisco.Load(imagen);

            }
            catch (Exception)
            {
                pcbImagenDisco.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOwRConBYl2t6L8QMOAQqa5FDmPB_bg7EnGA&s");

            }

        }

        private void btnListarEstilos_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormListaEstilo))
                    return;
            }
            FormListaEstilo ventana = new FormListaEstilo();
            //ventana.MdiParent = this;
            ventana.Show();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDisco agregar = new frmAgregarDisco();
            agregar.ShowDialog();
        }
    }
}
