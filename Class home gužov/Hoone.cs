using System;
using System.Collections.Generic;
using System.Text;

namespace Class_home_gužov
{
   public abstract class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public KorteriteMaja korteritemaja;
       
        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public abstract void NaitaInfo();
        
        
        public Uks GetUks()
        {
            return uks;
        }

        











    }
    



























}
