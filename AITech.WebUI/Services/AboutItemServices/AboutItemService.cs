using AITech.WebUI.DTOs.AboutItemDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client;

        public AboutItemService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutItemDto aboutDto)
        {
            await _client.PostAsJsonAsync("aboutItems", aboutDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("aboutItems/" + id);
        }

        public async Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutItemDto>>("aboutItems");
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutItemDto>("aboutItems/" + id);
        }

        public async Task UpdateAsync(UpdateAboutItemDto aboutDto)
        {
            await _client.PutAsJsonAsync("aboutItems", aboutDto);
        }
    }
}
