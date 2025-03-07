using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersPlatform.Entity
{
    public class Application : BaseEntity
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public ApplicationStatus Status { get; set; }
    }

    public enum ApplicationStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}
