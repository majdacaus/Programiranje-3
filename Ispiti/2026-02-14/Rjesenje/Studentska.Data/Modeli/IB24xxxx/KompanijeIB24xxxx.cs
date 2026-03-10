using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB24xxxx
{
    [Table("KompanijeIB24xxxx")]
    public class KompanijeIB24xxxx
    {
        public int Id {  get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }
        [ForeignKey("GradId")]
        public Grad Grad { get; set; }
        public string Adresa { get; set; }
        public string URL { get; set; }
        public byte[]? Logo { get; set; }
        public int MaxStudenata { get; set; }
        public bool Aktivna { get; set; }
    }
}
