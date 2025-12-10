using AITech.WebUI.DTOs.FAQDtos;

namespace AITech.WebUI.Services.FAQServices
{
    public class FAQService : IFAQService
    {
        private readonly HttpClient _client;

        public FAQService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFAQDto fAQDto)
        {
            await _client.PostAsJsonAsync("fAQs", fAQDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("fAQs/" + id);
        }

        public async Task<List<ResultFAQDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFAQDto>>("fAQs");
        }

        public async Task<UpdateFAQDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFAQDto>("fAQs/" + id);
        }

        public async Task UpdateAsync(UpdateFAQDto fAQDto)
        {
            await _client.PutAsJsonAsync("fAQs", fAQDto);
        }
    }
}
