using AITech.DataAccess.Repositories.FAQRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FAQDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.FAQServices
{
    public class FAQService(IFAQRepository _fAQRepository, IUnitOfWork _unitOfWork) : IFAQService
    {
        public async Task<List<ResultFAQDto>> TGetAllAsync()
        {
			var faq = await _fAQRepository.GetAllAsync();
			return faq.Adapt<List<ResultFAQDto>>();
		}

        public async Task<ResultFAQDto> TGetByIdAsync(int id)
        {
			var faq = await _fAQRepository.GetByIdAsync(id);
			if (faq is null)
			{
				throw new Exception("FAQ Bulunmadı");
			}
			return faq.Adapt<ResultFAQDto>();
		}

        public async Task TCreateAsync(CreateFAQDto createDto)
        {
			var faq = createDto.Adapt<FAQ>();
			await _fAQRepository.CreateAsync(faq);
			await _unitOfWork.SaveChangesAsync();
		}

        public async Task TUpdateAsync(UpdateFAQDto updateDto)
        {
			var faq = updateDto.Adapt<FAQ>();
			_fAQRepository.Update(faq);
			await _unitOfWork.SaveChangesAsync();
		}

        public async Task TDeleteAsync(int id)
        {
			var faq = await _fAQRepository.GetByIdAsync(id);
			if (faq is null)
			{
				throw new Exception("FAQ Bulunmadı");
			}
			_fAQRepository.Delete(faq);
			await _unitOfWork.SaveChangesAsync();
		}
    }
}
