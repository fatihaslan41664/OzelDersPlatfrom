using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersPlatform.Entity
{
    public class Lesson : BaseEntity
    {
        public Guid TeacherId { get; set; }
        public decimal Price { get; set; }
        public Teacher Teacher { get; set; }  // Teacher sınıfı
    }
}
