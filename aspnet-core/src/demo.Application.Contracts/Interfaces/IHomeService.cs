using demo.Application.Contrats.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace demo.Application.Contrats.Interfaces
{
    public interface IHomeService : IApplicationService
    {
        Task<PagedResultDto<HomeDto>> GetListAsync();
        Task<HomeDto> CreateAsync(string text);
        Task DeleteAsync(int id);
    }
}
