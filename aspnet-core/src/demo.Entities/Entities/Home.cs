using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace demo.Entities.Entities
{
    public class Home : Entity<int>
    {
        public string Name { get; set; }
        public int HomeStatusId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public Home() { }

    }
}
