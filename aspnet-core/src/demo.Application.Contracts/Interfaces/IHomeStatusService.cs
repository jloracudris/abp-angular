using demo.Application.Contrats.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Americasa.Demo.Interfaces
{
    public interface IHomeStatusService : IApplicationService
    {
        Task<PagedResultDto<HomeStatusDto>> GetListAsync();
        Task<HomeStatusDto> CreateAsync(string text);
        Task DeleteAsync(int id);
    }
}
