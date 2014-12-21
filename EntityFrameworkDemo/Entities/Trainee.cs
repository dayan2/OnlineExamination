using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Trainee
    {
        public int ID { get; set; }
        public string TraineeName { get; set; }

        public ICollection<TraineeExamEnrollment> TraineeExamEnrollments { get; set; }
        public ICollection<TraineeCourseEnrollment> TraineeCourseEnrollments { get; set; }
    }
}
