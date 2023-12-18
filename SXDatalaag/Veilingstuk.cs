using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXDatalaag
{
    public class Veilingstuk
    {

        [Key]
        public int Id { get; set; }
        public string StukName { get; set; }
        public string Aanbieder { get; set; }
        public string Categorie { get; set; }
        public string Beschrijving { get; set; }

        public int Gewicht { get; set; }
        public int Lengte { get; set; }
        public int Width { get; set; }
        public int Hoogte { get; set; }
        public string Image { get; set; }
        
        
    }
      
}
