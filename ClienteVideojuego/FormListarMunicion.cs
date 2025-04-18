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

    
    public partial class FormListarMunicion : Form
    {
       

        
        

        public FormListarMunicion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/Municion/");
            var response = client.Get(request);

            MessageBox.Show(response.Content); // 👈 Mostrá el JSON recibido

            var municiones = JsonSerializer.Deserialize<List<Municion>>(response.Content);

            CargarMunicionesEnTabla(municiones);
        }
        private void CargarMunicionesEnTabla(List<Municion> municiones)
        {


            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("cadencia", "Cadencia");
            dataGridView1.Columns.Add("danoArea", "Daño en Área");
            dataGridView1.Columns.Add("Index", "Índice");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            foreach (var Municion in municiones)
            {
                dataGridView1.Rows.Add(Municion.nombre, Municion.cadencia, Municion.danoArea, Municion.index);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
