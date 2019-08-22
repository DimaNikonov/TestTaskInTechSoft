using AutoMapper;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskInTechSoft.Entities;

namespace TestTaskInTechSoft.Mapping
{
    public class FaqGroupMapping:Profile
    {
        public FaqGroupMapping()
        {
            this.CreateMap<FaqGroup, FaqGroupViewModel>().ReverseMap();
            this.CreateMap<CreateFaqGroupViewModel, FaqGroup>();
        }
    }
}
