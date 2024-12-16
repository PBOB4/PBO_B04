using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_HalUtama
    {
        public List<string> MotivationalQuotes { get; private set; }

        public M_HalUtama()
        {
            MotivationalQuotes = new List<string>
            {
                "Hidup itu seperti secangkir teh, bagaimana rasanya, tergantung bagaimana kamu meraciknya.",
                "Secangkir teh menemani hariku, membukakan mataku tentang rasa cinta yang terbuang sia-sia. Baiklah, aku mulai berpaling dari penikmat senja menjadi penikmat rasa.",
                "Meski tak ada lagi perbincangan antara kita, aku tetap membuat dua cangkir teh, untukku dan kesunyianku.",
                "Seseorang harus seperti teh, kekuatannya yang sejati baru muncul ketika dia masuk ke dalam air panas.",
                "Tea is not just a drink. It's an expression of one's spirit.",
                "In tea, you find patience. In patience, you find yourself.",
                "The philosophy of tea is not mere aestheticism in the ordinary sense of the term, for it expresses comfort in simplicity rather than pride in luxury.",
                "The more you try to hold onto something, the more it slips through your fingers. The only thing you can truly control is your time and how you spend it.",
                "By the end of countless days, I can hear the sound of that day",
                "At times, people grow up through relying on others."
            };
        }
    }
}
