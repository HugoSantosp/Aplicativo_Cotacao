using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Aplicativo_Cotações
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void SearchCoin(string coin)
        {
            string url = "https://api.hgbrasil.com/finance?array_limit18&fields=only_results,"+coin+"&key=f368d0a5";

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if(response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    Market market = JsonConvert.DeserializeObject<Market>(result);
                    

                    if(tb_valor.Text == "")
                    {
                        lb_debug.Text = "Informe o Valor á ser Convertido";
                    }
                    else
                    {
                        decimal valor = decimal.Parse(tb_valor.Text);
                        decimal convercao = valor * market.Currency.BuyCoin;
                        lb_ValorConvertido.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", convercao);

                    }


                }
                else
                {
                    lb_ValorConvertido.Text = "Response errado";
                }
            }
           
        }
       
        private void label3_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_USD_Click(object sender, EventArgs e)
        { 
          SearchCoin(btn_USD.Text);

        }

        private void btn_EUR_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_EUR.Text);
        }

        private void btn_GBP_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_GBP.Text);
        }

        private void btn_ARS_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_ARS.Text);
        }

        private void btn_CAD_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_CAD.Text);
        }

        private void btn_AUD_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_AUD.Text);
        }

        private void btn_JPY_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_JPY.Text);
        }

        private void btn_CNY_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_CNY.Text);
        }

        private void btn_BTC_Click(object sender, EventArgs e)
        {
            SearchCoin(btn_BTC.Text);
        }
    }
}
