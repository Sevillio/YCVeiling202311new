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

        public DateTime EndDatumtijd { get; set; }

        public enum Veilingstatus
        {
            Scheduled,
            Open,
            Closed
            
        }
        public string Status { get; set; }
     
        public int OpeningsBod { get; set; }
        
        public int VeilingstukId { get; set; }

        [ForeignKey("VeilingstukId")]
        public Veilingstuk Veilingstuk { get; set; }
    }

}
