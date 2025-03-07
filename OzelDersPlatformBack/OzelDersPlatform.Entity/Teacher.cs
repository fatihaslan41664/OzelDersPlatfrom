using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersPlatform.Entity
{
    public class Teacher : BaseEntity
    {
        public string Branch { get; set; }  // Branş (Matematik, Kimya vb.)
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
