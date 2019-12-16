using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class EntityBase<T>
    {
        public T ID { get; set; }
        public bool Active { get; set; }
    }
}
