using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    public class CurrencyConverter
    {
        public float Convert(string From, string To)
        {
            HttpClient hc = new HttpClient();
            var ret = hc.GetAsync("https://exchange-rates.abstractapi.com/v1/live/?api_key=4941cef4bf0a46b2b1546a64279e4222&base=USD&target=TWD").Result;
            var JSON = ret.Content.ReadAsStringAsync().Result;

            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(JSON);
            return data.exchange_rates.TWD;
        }
    }
}
