using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TraineeExamEnrollment
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Marks { get; set; }

        public bool? IsApproved { get; set; }
        public int TraineeID { get; set; }
        public int ExaminationID { get; set; }
        public Examination Examination { get; set; }
        public Trainee Trainee { get; set; }
    }
}
