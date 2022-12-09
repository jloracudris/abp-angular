using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace demo.Entities.Entities
{
    public class LotStatus : Entity<int>
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public LotStatus() { }
    }
}
