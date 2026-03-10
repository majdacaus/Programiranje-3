using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB24xxxx
{
    public class ViewModelIB24xxxx
    {
        public int Id {  get; set; }
        public string Student { get; set; }
        public string Kompanija { get; set; }
        public string Grad {  get; set; }
        public DateTime DatumPrijave { get; set; }
        public string Status { get; set; }
        public DateTime? DatumPromjeneStatusa{ get; set; }
               
    }
}
