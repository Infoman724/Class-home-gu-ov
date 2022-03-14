using System;
using System.Collections.Generic;
using System.Text;

namespace Class_home_gužov
{
    public class EraMaja : Hoone
    {
       public string suurus;
       public int pindala;
        public EraMaja(int pindala = 50) : base(pindala)
        {
        }
        public string Suurus
        {

            get
            {
                var suurus = "";
                if (pindala < 50)
                { suurus = "vaike maja"; }
                else if (pindala < 100)
                { suurus = "keskmine maja"; }
                else if (pindala < 150)
                { suurus = "suur maja"; }
                else if (pindala <200)
                { suurus = "liiga suur maja"; }
                
                return suurus;
            }

        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"{Suurus}");
        }

    }
}
