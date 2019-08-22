using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class FaqGroup
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<FaqQuestion> FaqQuestions { get; set; }

    }
}
