using Americasa.Demo.Interfaces;
using demo.Application.Contrats.Dto;
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
    public class LotStatusService : ApplicationService, ILotStatusService
    {
        private readonly IRepository<LotStatus, int> _lotStatusRepository;

        public LotStatusService(IRepository<LotStatus, int> lotStatusRepository)
        {
            _lotStatusRepository = lotStatusRepository;
        }

        public async Task<LotStatusDto> CreateAsync(string text)
        {
            var lotStatus = await _lotStatusRepository.InsertAsync(
                new LotStatus { Name = text }
            );

            return new LotStatusDto
            {
                Name = lotStatus.Name,
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _lotStatusRepository.DeleteAsync(id);
        }

        public async Task<PagedResultDto<LotStatusDto>> GetListAsync()
        {
            var items = await _lotStatusRepository.GetListAsync();
            var totalCount = await _lotStatusRepository.GetCountAsync();

            var rs = items
                .Select(item => new LotStatusDto
                {
                    Name = item.Name,
                    Id = item.Id,
                }).ToList();

            return new PagedResultDto<LotStatusDto>(
                totalCount,
                rs
            );
        }
    }
}
