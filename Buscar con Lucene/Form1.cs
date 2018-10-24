using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buscar_con_Lucene.Search;
namespace Buscar_con_Lucene
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            //Presentar los datos a Indexar
            dtgColeccion.DataSource = SampleDataRepository.GetAll();
            lblEstado.Text = "Indice Aun no Creado";
        }

        //Crear el índice con Lucene
         private void btnIndexar_Click(object sender, EventArgs e)
        {
            LuceneSearch.AddUpdateLuceneIndex(SampleDataRepository.GetAll());
            lblEstado.Text = "¡El índice de búsqueda se creo exitosamente!";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Al enviar vacio el segundo argumento busca en todos los campos
            var resultados = LuceneSearch.Search(txtConsulta.Text,"");
            dtgSalida.DataSource = resultados;
        }

        private void btnInicializarIndice_Click(object sender, EventArgs e)
        {
            if (LuceneSearch.ClearLuceneIndex())
                lblEstado.Text = "Search index was cleared successfully!";
            else
                lblEstado.Text = "Index is locked and cannot be cleared, try again later or clear manually!";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Convertir la cadena a entero
            int idint;
            int.TryParse(txtId.Text, out idint);

            //capturar los datos del nuevo registro
            var new_record = new SampleData { Id = idint, Name = txtNombre.Text,
                                              Description = txtDescripcion.Text };
            LuceneSearch.AddUpdateLuceneIndex(new_record);

            //Actualizar los datos a indexar
            dtgColeccion.DataSource = SampleDataRepository.GetAll();
            
        }
    }
}
