﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Class_home_gužov
{
   public class KorteriteMaja :Hoone
    {
        public new int Pindala { get; set; }
        
        public KorteriteMaja(int pindala = 50)
        {
            Pindala = pindala;
        }




        public override void NaitaInfo()
        {
            Console.WriteLine($"Ma olen korter,ma olen {Pindala}m2");
        }

        
    }
}
