using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FaqGroupRepository : Repository<FaqGroup>, IFaqGroupRepository
    {
        public FaqGroupRepository(AppContext dbContext):base(dbContext)
        {                
        }        
    }
}
