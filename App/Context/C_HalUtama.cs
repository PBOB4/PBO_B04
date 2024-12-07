using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaSMart_App.App.Models;

namespace TeaSMart_App.App.Context
{
    internal class C_HalUtama
    {
        private readonly M_HalUtama _quotesManager;

        public C_HalUtama()
        {
            _quotesManager = new M_HalUtama();
        }

        public string GetRandomQuote()
        {
            if (_quotesManager.MotivationalQuotes.Count == 0)
            {
                return "Tidak ada kutipan yang tersedia.";
            }

            Random random = new Random();
            int index = random.Next(_quotesManager.MotivationalQuotes.Count);
            return _quotesManager.MotivationalQuotes[index];
        }
    }
}
