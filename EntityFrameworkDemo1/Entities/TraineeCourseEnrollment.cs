using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class TraineeCourseEnrollment
    {
        public int ID { get; set; }
        public int TraineeID { get; set; }
        public int CourseID { get; set; }

        public DateTime EnrolledDate { get; set; }
        public bool? IsEnrolled { get; set; }

        public Trainee Trainee { get; set; }
        public Course Courses { get; set; }
    }
}
