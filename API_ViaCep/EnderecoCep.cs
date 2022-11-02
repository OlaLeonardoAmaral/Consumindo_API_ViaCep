using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_ViaCep
{
    public class EnderecoCep
    {
        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }
        
        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }

        [JsonProperty(PropertyName = "localidade")]
        public string Localidade { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public string Uf { get; set; }

    }
}
