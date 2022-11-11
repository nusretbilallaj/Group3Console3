using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3Console3
{
    internal class Personi
    {
        public Personi(string emri,string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello person {Emri}");
        }
    }
}
