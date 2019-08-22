using AutoMapper;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskInTechSoft.Entities;

namespace TestTaskInTechSoft.Mapping
{
    public class FaqQuestionMapping: Profile
    {
        public FaqQuestionMapping()
        {
            this.CreateMap<FaqQuestion, FaqQuestionViewModel>().ReverseMap();
            this.CreateMap<CreateFaqQuestionViewModel, FaqQuestion>();
        }
    }
}
