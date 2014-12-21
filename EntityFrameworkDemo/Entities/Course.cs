using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }

        public ICollection<TraineeCourseEnrollment> TraineeCourseEnrollments { get; set; }
        public ICollection<Examination> Examinations { get; set; }
        public ICollection<Material> Materials { get; set; }
        //ICollection<T> is used because the IEnumerable<T> interface provides no way of adding items, removing items, 
        //or otherwise modifying the collection.
    }
}
