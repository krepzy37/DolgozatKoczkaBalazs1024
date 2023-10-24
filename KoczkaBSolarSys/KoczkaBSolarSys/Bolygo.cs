using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoczkaBSolarSys
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldSzam { get; set; }
        public float TerfogatFoldhoz { get; set; }

        public Bolygo(string p) 
        {
            var v = p.Split(';');
            Nev = v[0];
            HoldSzam= int.Parse(v[1]);
            TerfogatFoldhoz = float.Parse(v[2]);
        }
    }
}
