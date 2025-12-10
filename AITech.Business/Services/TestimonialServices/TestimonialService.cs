using AITech.DataAccess.Repositories.TestimonialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TestimonialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.TestimonialServices
{
	public class TestimonialService(ITestimonialRepository _testimonialRepository, IUnitOfWork _unitOfWork) : ITestimonialService
	{
        public async Task<List<ResultTestimonialDto>> TGetAllAsync()
        {
			var testimonials = await _testimonialRepository.GetAllAsync();
			return testimonials.Adapt<List<ResultTestimonialDto>>();
		}

        public async Task<ResultTestimonialDto> TGetByIdAsync(int id)
        {
			var testimonial = await _testimonialRepository.GetByIdAsync(id);
			if (testimonial is null)
			{
				throw new Exception("Referans Bulunmadı");
			}
			return testimonial.Adapt<ResultTestimonialDto>();
		}

        public async Task TCreateAsync(CreateTestimonialDto createDto)
        {
			var testimonial = createDto.Adapt<Testimonial>();
			await _testimonialRepository.CreateAsync(testimonial);
			await _unitOfWork.SaveChangesAsync();
		}

        public async Task TUpdateAsync(UpdateTestimonialDto updateDto)
        {
			var testimonial = updateDto.Adapt<Testimonial>();
			_testimonialRepository.Update(testimonial);
			await _unitOfWork.SaveChangesAsync();
		}

        public async Task TDeleteAsync(int id)
        {
			var testimonial = await _testimonialRepository.GetByIdAsync(id);
			if (testimonial is null)
			{
				throw new Exception("Referans Bulunmadı");
			}
			_testimonialRepository.Delete(testimonial);
			await _unitOfWork.SaveChangesAsync();
		}
    }
}
