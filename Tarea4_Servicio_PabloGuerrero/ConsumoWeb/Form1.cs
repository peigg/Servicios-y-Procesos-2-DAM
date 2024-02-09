using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ConsumoWeb
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }


        private async void btnCall_Click(object sender, EventArgs e)
        {
            try
            {
                
                string baseCurrency = "USD";
                string url = $"https://v6.exchangerate-api.com/v6/b067c8b6634ce145a2804d40/latest/{baseCurrency}";

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var exchangeRates = JsonConvert.DeserializeObject<ExchangeRates>(content);

                    if(exchangeRates != null && exchangeRates.result == "success" && exchangeRates.conversion_rates != null)
                    {
                        txtResponse.Text = $"Base Currency: {exchangeRates.base_code}\r\n";
                        txtResponse.AppendText("Exchange Rates:\r\n");
                        txtResponse.AppendText($"EUR: {exchangeRates.conversion_rates["EUR"]}\r\n");
                        txtResponse.AppendText($"GBP: {exchangeRates.conversion_rates["GBP"]}\r\n");
                        txtResponse.AppendText($"CAD: {exchangeRates.conversion_rates["CAD"]}\r\n");
                        txtResponse.AppendText($"JPY: {exchangeRates.conversion_rates["JPY"]}\r\n");
                        txtResponse.AppendText($"CNY: {exchangeRates.conversion_rates["CNY"]}\r\n");
                        
                    }
                    else
                    {
                        txtResponse.Text = "Error: The service answer does not contain the seeked information.";
                    }
                }
                else
                {
                    txtResponse.Text = $"Error calling the web service. Status Code: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Error: " + ex.Message;
            }
        }

        public class ExchangeRates
    {
        public string result { get; set; }
        public string base_code { get; set; }
        public Dictionary<string, double> conversion_rates { get; set; }
    }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
