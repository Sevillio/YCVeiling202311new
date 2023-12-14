using SXDatalaag.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SXDatalaag
{
    public class Veiling
    {
        

        public int Id { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        public DateTime StartDatumTijd { get; set; }
        public enum Veilingstatus { scheduled, open, closed }
        public int Duratie { get; set; }
        public int OpeningsBod { get; set; }
        public int LaatsteBod { get; set; }
        public int MinimumBod { get; set; }
        public int VeilingstukId { get; set; }

        [ForeignKey("VeilingstukId")]
        public Veilingstuk Veilingstuk { get; set; } 
    }

}
