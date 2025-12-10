using AITech.WebUI.DTOs.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutDto aboutDto)
        {
            await _client.PostAsJsonAsync("abouts", aboutDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("abouts/" + id);
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
        }

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutDto>("abouts/" + id);
        }

        public async Task UpdateAsync(UpdateAboutDto aboutDto)
        {
            await _client.PutAsJsonAsync("abouts", aboutDto);
        }
    }
}
