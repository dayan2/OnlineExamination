using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Examination
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int CutOffMark { get; set; }

        public List<Question> QuestionID { get; set; }
    }
}
