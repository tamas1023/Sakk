using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Babuk
    {
        private int id;
        private string tipus;
        private string szin;

        public Babuk(int id, string tipus, string szin)
        {
            Id = id;
            Tipus = tipus;
            Szin = szin;
        }
        public void lephete()
        {
            
        }

        public int Id { get => id; set => id = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Szin { get => szin; set => szin = value; }
    }
}
