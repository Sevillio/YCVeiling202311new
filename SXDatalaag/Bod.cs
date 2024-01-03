using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXDatalaag
{
    public class Bod
    {
        public int id {  get; set; }
        public int Prijs {  get; set; }

        public int LaatsteBod { get; set; }
        public int MinimumBod { get; set; }

        public int AccountId { get; set; }
        public int VeilingstukId { get; set; }


        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        [ForeignKey("VeilingstukId")]
        public Veilingstuk Veilingstuk { get; set; }

    }
}
