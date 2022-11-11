using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3Console3
{
    internal class Studenti:Personi
    {
        public Studenti(string emri,string mbiemri):base(emri, mbiemri)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello student {Emri} {Mbiemri}");
        }

    }
}
