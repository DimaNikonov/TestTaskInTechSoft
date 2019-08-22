using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWorks
    {
        IFaqGroupRepository FaqGroupRepository { get; }

        IFaqQuestionRepositiry FaqQuestionRepositiry { get; }

        Task SaveAsync();

    }
}
