using Americasa.Demo.Interfaces;
using demo.Application.Contrats.Dto;
using demo.Application.Contrats.Interfaces;
using demo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Americasa.Demo
{
    public class DealerShipService : ApplicationService, IDealerShipService
    {
        private readonly IRepository<DealerShip, int> _dealerShipRepository;

        public DealerShipService(IRepository<DealerShip, int> dealerShipRepository)
        {
            _dealerShipRepository = dealerShipRepository;
        }

        public async Task<DealerShipDto> CreateAsync(string text)
        {
            var dealerShip = await _dealerShipRepository.InsertAsync(
                new DealerShip { Name = text }
            );

            return new DealerShipDto
            {
                Id = dealerShip.Id,
                Name = dealerShip.Name
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _dealerShipRepository.DeleteAsync(id);
        }

        public async Task<PagedResultDto<DealerShipDto>> GetListAsync()
        {
            var items = await _dealerShipRepository.GetListAsync();
            var totalCount = await _dealerShipRepository.GetCountAsync();

            var rs = items
                .Select(item => new DealerShipDto
                {
                    Id = item.Id,
                    Name = item.Name
                }).ToList();

            return new PagedResultDto<DealerShipDto>(
                totalCount,
                rs
            );
        }
    }
}
