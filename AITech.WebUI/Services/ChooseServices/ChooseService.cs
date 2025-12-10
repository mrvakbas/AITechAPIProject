using AITech.WebUI.DTOs.ChooseDtos;
using AITech.WebUI.DTOs.ProjectDtos;

namespace AITech.WebUI.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _client;

        public ChooseService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateChooseDto chooseDto)
        {
            await _client.PostAsJsonAsync("chooses", chooseDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("chooses/" + id);
        }

        public async Task<List<ResultChooseDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultChooseDto>>("chooses");
        }

        public async Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateChooseDto>("chooses/" + id);
        }

        public async Task UpdateAsync(UpdateChooseDto chooseDto)
        {
            await _client.PutAsJsonAsync("chooses", chooseDto);
        }
    }
}
