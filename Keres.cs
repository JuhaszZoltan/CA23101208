using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA23101208
{
    internal class Keres
    {
        public string Cim { get; set; }
        public string DatumIdo { get; set; }
        public string Get { get; set; }
        public string AllapotKod { get; set; }
        public string Meret { get; set; }

        public Keres(string beolvasottSor)
        {
            string[] darabok = beolvasottSor.Split('*');
            Cim = darabok[0];
            DatumIdo = darabok[1];
            Get = darabok[2];
            string[] allapotEsMeret = darabok[3].Split(' ');
            AllapotKod = allapotEsMeret[0];
            Meret = allapotEsMeret[1];
        }

    }
}
