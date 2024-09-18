using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Financy
    {

        private readonly CurrencyConverter _currencyConverter;

        public Financy(CurrencyConverter currencyConverter)
        {
            _currencyConverter = currencyConverter;
        }

        public Financy() : this(new CurrencyConverter())
        {
        }

        public double USD2TWD(double amount)
        {
            var currencyConverter = new CurrencyConverter();
            double rate = currencyConverter.Convert("USD", "TWD");
            return amount * rate;
        }

        public double SplitMoney(double USDAmount, int People)
        {
            var currencyConverter = _currencyConverter;
            //使用到外部函式(抓取匯率)
            double rate = currencyConverter.Convert("USD", "TWD");
            //計算台幣總金額
            double Total = USDAmount * rate;
            //回傳一個人需要付多少錢(台幣)
            return Total / People;
        }
    }
}
