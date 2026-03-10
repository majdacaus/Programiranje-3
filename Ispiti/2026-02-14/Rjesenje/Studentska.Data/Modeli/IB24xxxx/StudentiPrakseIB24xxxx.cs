using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB24xxxx
{
    public enum StatusPrakse
    {
        PODNESENA,
        PRIHVACENA,
        ODBIJENA,
        REALIZOVANA
    }
    [Table("StudentiPrakseIB24xxxx")]
    public class StudentiPrakseIB24xxxx
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public int KompanijaId { get; set; }
        [ForeignKey("KompanijaId")]
        public KompanijeIB24xxxx Kompanija { get; set; }
        public DateTime DatumPrijave { get; set; }

        public StatusPrakse Status { get; set; }
        public DateTime? DatumPromjeneStatusa { get; set; }

    }
}
