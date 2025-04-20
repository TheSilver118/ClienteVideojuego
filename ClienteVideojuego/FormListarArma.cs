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
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("nombre", "nombre");
            dataGridView1.Columns.Add("daño", "daño");
            dataGridView1.Columns.Add("municion", "municion");
            dataGridView1.Columns.Add("vida", "vida");
            dataGridView1.Columns.Add("velocidad", "velocidad");
            dataGridView1.Columns.Add("fechaCreacion", "fechaCreacion");
            dataGridView1.Columns.Add("nombreMunicion", "nombreMunicion");
            dataGridView1.Columns.Add("cadencia", "cadencia");
            dataGridView1.Columns.Add("danoArea", "danoArea");
            

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            foreach (var arma in armas)
            {
                string fechaFormateada = arma.FechaCreacionDate.ToString("dd/MM/yyyy HH:mm:ss");

                dataGridView1.Rows.Add(
                    arma.nombre,
                    arma.daño,
                    arma.municion,
                    arma.vida,
                    arma.velocidad,
                    fechaFormateada,
                    arma.tipoMunicion.nombreMunicion,
                    arma.tipoMunicion.dañoArea,
                    arma.tipoMunicion.cadencia
                );
            }

            dataGridView1.DataSource = dataGridView1;
        }

    }
}
