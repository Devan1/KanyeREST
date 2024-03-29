﻿using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");
        }
        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronSwansonResponse = client.GetStringAsync(ronSwansonURL).Result;
            var ronSwansonQuote = JArray.Parse(ronSwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();
            Console.WriteLine($"Ron: {ronSwansonQuote}");
        }
    }
}
