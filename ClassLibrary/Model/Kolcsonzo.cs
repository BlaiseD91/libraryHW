using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Kolcsonzo
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string SzulIdo { get; set; }
        public ICollection<Kolcsonzes> Kolcsonzes { get; } = new List<Kolcsonzes>();

        public Kolcsonzo()
        {
        }

        public Kolcsonzo(string sor)
        {
            string[] s = sor.Split(";");
            Nev = s[0];
            SzulIdo = s[1];
        }
    }
}
