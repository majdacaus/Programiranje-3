using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB24xxxx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB24xxxx
{
    public class StudentiPrakseServisIB24xxxx : BaseServis<StudentiPrakseIB24xxxx>
    {
        public override List<StudentiPrakseIB24xxxx> GetAll()
        {
            if (_dbContext == null) return [];

            return [.. _dbContext.Set<StudentiPrakseIB24xxxx>()
                .Include(x => x.Student)
                .Include(x => x.Kompanija)
                    .ThenInclude(k => k.Grad)];
        }
    }
}
