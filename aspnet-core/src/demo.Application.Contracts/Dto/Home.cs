using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace demo.Application.Contrats.Dto
{
    public class HomeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HomeStatusId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
