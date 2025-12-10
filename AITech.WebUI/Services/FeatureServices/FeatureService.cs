using AITech.WebUI.DTOs.FeatureDtos;
using AITech.WebUI.DTOs.ProjectDtos;

namespace AITech.WebUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client;

        public FeatureService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFeatureDto featureDto)
        {
            await _client.PostAsJsonAsync("features", featureDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("features/" + id);
        }

        public async Task<List<ResultFeatureDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFeatureDto>>("features");
        }

        public async Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFeatureDto>("features/" + id);
        }

        public async Task UpdateAsync(UpdateFeatureDto featureDto)
        {
            await _client.PutAsJsonAsync("features", featureDto);
        }
    }
}
