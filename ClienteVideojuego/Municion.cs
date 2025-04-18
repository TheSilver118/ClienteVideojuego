using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClienteVideojuego
{
    internal class Municion
    {
        [JsonPropertyName("nombre")]
        public string nombre { get; set; }

        [JsonPropertyName("cadencia")]
        public int cadencia { get; set; } // 👈 tipo correcto

        [JsonPropertyName("danoArea")]
        public bool danoArea { get; set; }

        [JsonPropertyName("index")]
        public int index { get; set; }
    }
}
