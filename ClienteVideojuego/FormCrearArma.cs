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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ClienteVideojuego
{
    public partial class FormCrearArma : Form
    {
        public FormCrearArma()
        {
            InitializeComponent();

            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/Municion/");
            var response = client.Get(request);

            MessageBox.Show(response.Content); // 👈 Mostrá el JSON recibido

            var municiones = JsonSerializer.Deserialize<List<Municion>>(response.Content);

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = textNombre.Text.Trim();
            int daño = (int)numericUpDown1.Value;
            int vida = (int)numericUpDown2.Value;
            int velocidad = (int)numericUpDown3.Value;
            int municion = (int)numericUpDown4.Value;
            string fechaCreacion = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            


            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest("/Arma/");

            request.RequestFormat = DataFormat.Json;

            request.AddBody(new
            {

                daño = daño,
                municion = municion,
                nombre = nombre,
                vida = vida,
                velocidad = velocidad,
                fechaCreacion = fechaCreacion
            });

            var response = client.Post(request);
            MessageBox.Show("Response: " + response.StatusCode);




        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
