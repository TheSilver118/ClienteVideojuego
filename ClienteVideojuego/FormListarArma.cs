using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace ClienteVideojuego
{
    public partial class FormListarArma : Form
    {
        public FormListarArma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/Arma/");
            var response = client.Get(request);

            MessageBox.Show(response.Content); // 👈 Mostrá el JSON recibido

            var armas = JsonSerializer.Deserialize<List<Arma>>(response.Content);

            CargarArmasEnTabla(armas);
        }

        private void CargarArmasEnTabla(List<Arma> armas)
        {
            var tabla = new DataTable();
            dataGridView1.Columns.Add("nombre","Nombre");
            dataGridView1.Columns.Add("daño", "Daño");
            dataGridView1.Columns.Add("munición", "Municion");
            dataGridView1.Columns.Add("vida", "Vida");
            dataGridView1.Columns.Add("velocidad", "Velocida");
            dataGridView1.Columns.Add("fechaCreación", "Fecha Creacion");
            dataGridView1.Columns.Add("tipoMunición", "Nombre");
            dataGridView1.Columns.Add("danoArea", "DanoArea");
            dataGridView1.Columns.Add("cadencia", "Cadencia");

            foreach (var arma in armas)
            {
                tabla.Rows.Add(
                    arma.nombre,
                    arma.daño,
                    arma.municion,
                    arma.vida,
                    arma.velocidad,
                    arma.fechaCreacion,
                    arma.tipoMunicion.nombre,
                    arma.tipoMunicion.danoArea,
                    arma.tipoMunicion.cadencia
                );
            }

            dataGridView1.DataSource = tabla;
        }

    }
}
