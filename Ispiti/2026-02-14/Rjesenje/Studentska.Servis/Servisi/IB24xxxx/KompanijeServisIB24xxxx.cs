using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB24xxxx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB24xxxx
{
    public class KompanijeServisIB24xxxx : BaseServis<KompanijeIB24xxxx>
    {
        public override List<KompanijeIB24xxxx> GetAll()
        {
            return _dbContext.Kompanije.Include(x => x.Grad).ToList();
        }
    }
}
