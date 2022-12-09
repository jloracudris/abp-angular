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
    public class HomeService : ApplicationService, IHomeService
    {
        private readonly IRepository<Home, int> _houseRepository;

        public HomeService(IRepository<Home, int> houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public async Task<HomeDto> CreateAsync(string text)
        {
            var house = await _houseRepository.InsertAsync(
                new Home { Name = text, HomeStatusId = 1 }
            );

            return new HomeDto
            {
                Name = house.Name,
                HomeStatusId = house.HomeStatusId,
                Id = house.Id,
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _houseRepository.DeleteAsync(id);
        }

        public async Task<PagedResultDto<HomeDto>> GetListAsync()
        {
            var items = await _houseRepository.GetListAsync();
            var totalCount = await _houseRepository.GetCountAsync();

            var rs = items
                .Select(item => new HomeDto
                {
                    Name = item.Name,
                    HomeStatusId = item.HomeStatusId,
                    Id = item.Id,
                }).ToList();

            return new PagedResultDto<HomeDto>(
                totalCount,
                rs
            );
        }
    }
}
