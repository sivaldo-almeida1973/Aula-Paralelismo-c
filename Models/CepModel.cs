using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Paralelismo.Models
{
    //criando metodo---------------------
    public class CepModel
    {
        [JsonPropertyName("cep")]

        public string Cep {get; set; }
        [JsonPropertyName("Logradouro")]

        public string Logradouro {get; set; }
        [JsonPropertyName("complemento")]

        public string Complemento {get; set; }
        [JsonPropertyName("bairro")]

          public string Bairro {get; set; }
        [JsonPropertyName("Localidade")]

        public string Localidade {get; set; }
        [JsonPropertyName("uf")]


        public string Uf {get; set; }
        [JsonPropertyName("ibge")]

        public string IBGE {get; set; }
        [JsonPropertyName("gia")]

        public string Gia {get; set; }
        [JsonPropertyName("ddd")]

          public string DDD {get; set; }
        [JsonPropertyName("Siaf")]

        public string Siaf {get; set;}


        public override string ToString()
        {
            return $"{this.Cep} - {this.Uf} - {this.Bairro} - {this.Localidade}";
        }


    }
}