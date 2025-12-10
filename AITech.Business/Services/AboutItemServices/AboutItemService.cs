using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutItemDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutItemServices
{
	public class AboutItemService(IAboutItemRepository _aboutItemRepository, IUnitOfWork _unitOfWork): IAboutItemService
	{
		public async Task<List<ResultAboutItemDto>> TGetAllAsync()
		{
			var aboutItems = await _aboutItemRepository.GetAllAsync();
			return aboutItems.Adapt<List<ResultAboutItemDto>>();
		}

		public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
		{
			var aboutItem = await _aboutItemRepository.GetByIdAsync(id);
			if (aboutItem is null)
			{
				throw new Exception("Item Bulunmadı");
			}
			return aboutItem.Adapt<ResultAboutItemDto>();
		}

		public async Task TCreateAsync(CreateAboutItemDto createDto)
		{
			var aboutItem = createDto.Adapt<AboutItem>();
			await _aboutItemRepository.CreateAsync(aboutItem);
			await _unitOfWork.SaveChangesAsync();
		}

		public async Task TUpdateAsync(UpdateAboutItemDto updateDto)
		{
			var aboutItem = updateDto.Adapt<AboutItem>();
			_aboutItemRepository.Update(aboutItem);
			await _unitOfWork.SaveChangesAsync();
		}

		public async Task TDeleteAsync(int id)
		{
			var aboutItem = await _aboutItemRepository.GetByIdAsync(id);
			if (aboutItem is null)
			{
				throw new Exception("Item Bulunmadı");
			}
			_aboutItemRepository.Delete(aboutItem);
			await _unitOfWork.SaveChangesAsync();
		}
	}
}
