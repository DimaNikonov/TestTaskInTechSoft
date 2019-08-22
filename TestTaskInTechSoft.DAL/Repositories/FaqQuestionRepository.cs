using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FaqQuestionRepository :Repository<FaqQuestion>, IFaqQuestionRepositiry
    {
        public FaqQuestionRepository(AppContext dbContext):base(dbContext)
        {            
        }        
    }
}
