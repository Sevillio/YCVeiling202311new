using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXDatalaag
{
    public class Veilingstuk
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Aanbieder {  get; set; }
        public string Categorie { get; set; }
        public string Beschrijving { get; set; }

        public int Gewicht { get; set; }
        public int Lengte { get; set; }
        public int Width { get; set; }
        public int Hoogte { get; set; }
        
    }
}
