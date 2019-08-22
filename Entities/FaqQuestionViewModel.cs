using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskInTechSoft.Entities
{
    public class FaqQuestionViewModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public int FaqGroupViewModelId { get; set; }
    }
}
