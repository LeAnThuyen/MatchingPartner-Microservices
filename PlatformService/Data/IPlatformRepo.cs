﻿using PlatformService.DTO;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        Task<IEnumerable<PlatformReadDto>> GetAllPlatForm(PlatformGetListDto input);
        Task<PlatForm> GetPlatFormAsync(int id);
        Task<int> CreatePlatForm(PlatFormCreateUpdateDto platForm);
        Task<int> UpdatePlatForm(PlatFormCreateUpdateDto platForm);
        Task<int> DeletePlatForm(int id);
    }
}
