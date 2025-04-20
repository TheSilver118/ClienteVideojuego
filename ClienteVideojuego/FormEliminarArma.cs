using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace ClienteVideojuego
{
    public partial class FormEliminarArma : Form
    {

        Arma armaActual;

        public FormEliminarArma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            var nombre = textNombre.Text;
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/Arma/buscarNombre");

            request.RequestFormat = DataFormat.Json;

            request.AddBody(new
            {

                nombre = nombre
            });



            var response = client.Post(request);

            MessageBox.Show(response.Content);
            var arma = JsonSerializer.Deserialize<Arma>(response.Content);
            mostrarArma(arma);
            armaActual = arma;
        }

        private void mostrarArma(Arma arma)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("municion", "Cargador");
            dataGridView1.Columns.Add("dano", "Daño");
            dataGridView1.Columns.Add("vida", "Vida");
            dataGridView1.Columns.Add("velocidad", "Velocidad");
            dataGridView1.Columns.Add("fechaCreacion", "Fecha Creacion");
            dataGridView1.Columns.Add("tipoMunicion", "Tipo municion");
            dataGridView1.Columns.Add("danoArea", "Daño en area");
            dataGridView1.Columns.Add("cadencia", "Cadencia");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Add(arma.nombre, arma.municion, arma.daño, arma.vida, arma.velocidad, arma.fechaCreacion, arma.tipoMunicion.nombreMunicion, arma.tipoMunicion.dañoArea, arma.tipoMunicion.cadencia);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/Arma/");

            request.RequestFormat = DataFormat.Json;

            request.AddBody(new
            {
                tipo = "Rifle",
                indice = armaActual.indice
            });



            var response = client.Delete(request);


            MessageBox.Show(response.Content);
        }

        private void txt_eliminar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
