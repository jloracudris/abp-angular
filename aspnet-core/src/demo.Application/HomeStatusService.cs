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
    public class HomeStatusService : ApplicationService, IHomeStatusService
    {
        private readonly IRepository<HomeStatus, int> _houseStatusRepository;

        public HomeStatusService(IRepository<HomeStatus, int> houseStatusRepository)
        {
            _houseStatusRepository = houseStatusRepository;
        }

        public async Task<HomeStatusDto> CreateAsync(string text)
        {
            var houseStatus = await _houseStatusRepository.InsertAsync(
                new HomeStatus { Name = text }
            );

            return new HomeStatusDto
            {
                Name = houseStatus.Name,
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _houseStatusRepository.DeleteAsync(id);
        }

        public async Task<PagedResultDto<HomeStatusDto>> GetListAsync()
        {
            var items = await _houseStatusRepository.GetListAsync();
            var totalCount = await _houseStatusRepository.GetCountAsync();

            var rs = items
                .Select(item => new HomeStatusDto
                {
                    Name = item.Name,
                }).ToList();

            return new PagedResultDto<HomeStatusDto>(
                totalCount,
                rs
            );
        }
    }
}
