using AITech.WebUI.DTOs.AboutItemDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public interface IAboutItemService
    {
        Task<List<ResultAboutItemDto>> GetAllAsync();
        Task<UpdateAboutItemDto> GetByIdAsync(int id);
        Task CreateAsync(CreateAboutItemDto aboutDto);
        Task UpdateAsync(UpdateAboutItemDto aboutDto);
        Task DeleteAsync(int id);
    }
}
