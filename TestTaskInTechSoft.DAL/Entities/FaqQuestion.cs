using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class FaqQuestion
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public int FaqGroupId { get; set; }

        public FaqGroup FaqGroup { get; set; }
    }
}
