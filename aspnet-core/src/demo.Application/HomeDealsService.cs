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
    public class HomeDealsService : ApplicationService, IHomeDealService
    {
        private readonly IRepository<HomeDeal, int> _houseDealsRepository;

        public HomeDealsService(IRepository<HomeDeal, int> houseDealsRepository)
        {
            _houseDealsRepository = houseDealsRepository;
        }

        public async Task<HomeDealDto> CreateAsync(string text)
        {
            var deal = await _houseDealsRepository.InsertAsync(
                new HomeDeal { Name = text }
            );

            return new HomeDealDto
            {   
                Name = deal.Name,
                Attachment = deal.Attachment,
                BoxSize = deal.BoxSize,
                CreationTime = DateTime.Now,
                DealId = deal.DealId,
                Email = deal.Email,
                HomeStatusId = deal.HomeStatusId,                
                HouseName = deal.HouseName,                
                LotNumber = deal.LotNumber,
                LotStatusId = deal.LotStatusId,
                PhoneNumber = deal.PhoneNumber,
                UpdateTime = DateTime.Now,
                WindZone = deal.WindZone,
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _houseDealsRepository.DeleteAsync(id);
        }

        public async Task<PagedResultDto<HomeDealDto>> GetListAsync()
        {
            var deals = await _houseDealsRepository.GetListAsync();
            //Get the total count with another query
            var totalCount = await _houseDealsRepository.GetCountAsync();


            var rs = deals
                .Select(deal => new HomeDealDto
                {
                    Name = deal.Name,
                    Attachment = deal.Attachment,
                    BoxSize = deal.BoxSize,
                    CreationTime = DateTime.Now,
                    DealId = deal.DealId,
                    Email = deal.Email,
                    HomeStatusId = deal.HomeStatusId,
                    HouseName = deal.HouseName,
                    LotNumber = deal.LotNumber,
                    LotStatusId = deal.LotStatusId,
                    PhoneNumber = deal.PhoneNumber,
                    UpdateTime = DateTime.Now,
                    WindZone = deal.WindZone,
                }).ToList();

            return new PagedResultDto<HomeDealDto>(
                totalCount,
                rs
            );
        }
    }
}
