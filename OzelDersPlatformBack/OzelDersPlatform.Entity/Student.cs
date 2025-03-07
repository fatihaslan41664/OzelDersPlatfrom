using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersPlatform.Entity
{
    public class Student : BaseEntity
    {
        public List<Application> Applications { get; set; } = new List<Application>();
    }
}
