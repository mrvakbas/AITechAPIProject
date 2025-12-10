using AITech.WebUI.DTOs.TestimonialDtos;

namespace AITech.WebUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _client;

        public TestimonialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateTestimonialDto testimonialDto)
        {
            await _client.PostAsJsonAsync("testimonials", testimonialDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("testimonials/" + id);
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonials");
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateTestimonialDto>("testimonials/" + id);
        }

        public async Task UpdateAsync(UpdateTestimonialDto testimonialDto)
        {
            await _client.PutAsJsonAsync("testimonials", testimonialDto);
        }
    }
}
