using System;
using System.Collections.Generic;
using System.Text;

namespace Class_home_gužov
{
    public class Uks
    {
        public string Color { get; set; }

        public Uks(string color = "sinine")
        {
            Color = color;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}");
        }
    }
}
