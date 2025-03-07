using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersPlatform.Entity
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }  // Bu, genel olarak tüm varlıklar için geçerli olabilir
    }
}
