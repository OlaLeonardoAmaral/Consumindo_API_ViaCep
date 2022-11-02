using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_ViaCep
{
    public partial class ViaCep : Form
    {
        public ViaCep()
        {
            InitializeComponent();
        }

        private void pesquisarCep_Click(object sender, EventArgs e)
        {
            string strURL = String.Format("https://viacep.com.br/ws/{0}/json/", cep.Text);

            using(HttpClient cliente = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = cliente.GetAsync(strURL).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        EnderecoCep enderecoCep = JsonConvert.DeserializeObject<EnderecoCep>(result);

                        endereco.Text = enderecoCep.Logradouro;
                        bairro.Text = enderecoCep.Bairro;
                        cidade.Text = enderecoCep.Localidade;
                        uf.Text = enderecoCep.Uf;
                    }
                    else
                    {
                        endereco.Text = "-";
                        bairro.Text = "-";
                        cidade.Text = "-";
                        uf.Text = "-";
                    }
                }
                catch (Exception ex)
                {
                    endereco.Text = "-";
                    bairro.Text = "-";
                    cidade.Text = "-";
                    uf.Text = "-";

                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
