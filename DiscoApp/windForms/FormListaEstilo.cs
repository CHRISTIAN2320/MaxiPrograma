using Dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DiscoAdoNet
{

    public partial class FormListaEstilo : Form
    {
        private List<Estilo> listaEstilo;
        public FormListaEstilo()
        {
            InitializeComponent();
        }

       

        private void FormListaEstilo_Load(object sender, EventArgs e)
        {
            try
            {
                EstiloNegocio negocio = new EstiloNegocio();
                // Es mejor asignar la lista directamente al DataSource
                listaEstilo = negocio.listar();
                dgvListaEstilo.DataSource = listaEstilo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.ToString());
            }
        }
    }
}
