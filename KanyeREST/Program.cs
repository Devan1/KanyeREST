﻿using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.RonQuote();
                Console.WriteLine();
                QuoteGenerator.KanyeQuote();
                Console.WriteLine();
            }            
        }
    }
}
