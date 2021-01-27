using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinCalculatorr
{
    public partial class Form1 : Form
    {
        public object ResultLbl { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void getRatesBtn_Click(object sender, EventArgs e)
        {
            if (currencyMenu.SelectedItem.ToString() == "EUR")
            {
                
                result.Visible = true;

                BitCoinRates ResultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBts.Text);
                float CurrentRate = ResultRates.bpi.EUR.rate_float;
                float btcResult = userCoins * CurrentRate;
                result.Text = $"{btcResult} {ResultRates.bpi.EUR.code}";
            }

            if (currencyMenu.SelectedItem.ToString() == "USD")
            {
                
                result.Visible = true;

                BitCoinRates ResultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBts.Text);
                float CurrentRate = ResultRates.bpi.USD.rate_float;
                float btcResult = userCoins * CurrentRate;
                result.Text = $"{btcResult} {ResultRates.bpi.USD.code}";
            }

            if (currencyMenu.SelectedItem.ToString() == "GBP")
            {
               
                result.Visible = true;

                BitCoinRates ResultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBts.Text);
                float CurrentRate = ResultRates.bpi.GBP.rate_float;
                float btcResult = userCoins * CurrentRate;
                result.Text = $"{btcResult} {ResultRates.bpi.GBP.code}";
            }

        }

        public static BitCoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            BitCoinRates bitcoin;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }
            return bitcoin;
        }
    }
}
