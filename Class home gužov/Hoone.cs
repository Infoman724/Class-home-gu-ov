using System;
using System.Collections.Generic;
using System.Text;

namespace Class_home_gužov
{
   public class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
       
        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
        }
        
        public Uks GetUks()
        {
            return uks;
        }













    }
    



























}
