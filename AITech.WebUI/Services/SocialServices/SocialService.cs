using AITech.WebUI.DTOs.SocialDtos;

namespace AITech.WebUI.Services.SocialServices
{
    public class SocialService : ISocialService
    {
        private readonly HttpClient _client;

        public SocialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateSocialDto socialDto)
        {
            await _client.PostAsJsonAsync("socials", socialDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("socials/" + id);
        }

        public async Task<List<ResultSocialDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultSocialDto>>("socials");
        }

        public async Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateSocialDto>("socials/" + id);
        }

        public async Task UpdateAsync(UpdateSocialDto socialDto)
        {
            await _client.PutAsJsonAsync("socials", socialDto);
        }
    }
}
