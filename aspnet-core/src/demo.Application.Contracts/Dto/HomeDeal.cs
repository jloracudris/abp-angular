using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace demo.Application.Contrats.Dto
{
    public class HomeDealDto
    {
        public int DealId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LotNumber { get; set; }
        public string HouseName { get; set; }
        public string BoxSize { get; set; }
        public string WindZone { get; set; }
        public string Attachment { get; set; }
        public int HomeStatusId { get; set; }
        public int LotStatusId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
