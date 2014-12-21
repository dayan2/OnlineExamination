using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Question
    {
        public int ID { get; set; }
        public string QuestionDes { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int Correct { get; set; }

        public Examination ExaminationID { get; set; }

        //public Examination Examination { get; set; }
        public List<Choice> Choices { get; set; }
    }
}
