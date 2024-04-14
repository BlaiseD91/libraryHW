using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Kolcsonzes
    {
        public int Id { get; set; }
        public int KolcsonzoId { get; set; }
        public string Iro { get; set; }
        public string Mufaj { get; set; }
        public string Cim { get; set; }

        public Kolcsonzes()
        {
        }

        public Kolcsonzes(string sor)
        {
            string[] s = sor.Split(";");
            KolcsonzoId = Convert.ToInt32(s[0]);
            Iro = s[1];
            Mufaj = s[2];
            Cim = s[3];
        }
    }
}
