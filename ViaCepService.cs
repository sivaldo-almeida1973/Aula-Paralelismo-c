using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Paralelismo.Models;

namespace Paralelismo.bin
{
    public class ViaCepService
    {
        //consumo do webServices------------------------------
        public CepModel GetCep(string cep)
        {
            var client = new HttpClient();
            var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var cepResult = JsonSerializer.Deserialize<CepModel>(content);


            return cepResult;

        }
        
    }
}