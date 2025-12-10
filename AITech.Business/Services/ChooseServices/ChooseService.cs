using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ChooseDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.ChooseServices
{
    public class ChooseService(IChooseRepository _chooseRepository, IUnitOfWork _unitOfWork) : IChooseService
    {
        public async Task<List<ResultChooseDto>> TGetAllAsync()
        {
			var chooses = await _chooseRepository.GetAllAsync();
			return chooses.Adapt<List<ResultChooseDto>>();
		}

        public async Task<ResultChooseDto> TGetByIdAsync(int id)
        {
			var choose = await _chooseRepository.GetByIdAsync(id);
			if (choose is null)
			{
				throw new Exception("Choose Bulunmadı");
			}
			return choose.Adapt<ResultChooseDto>();
		}

        public async Task TCreateAsync(CreateChooseDto createDto)
        {
			var choose = createDto.Adapt<Choose>();
			await _chooseRepository.CreateAsync(choose);
			await _unitOfWork.SaveChangesAsync();
		}

        public async Task TUpdateAsync(UpdateChooseDto updateDto)
        {
			var choose = updateDto.Adapt<Choose>();
			_chooseRepository.Update(choose);
			await _unitOfWork.SaveChangesAsync();
		}

        public async Task TDeleteAsync(int id)
        {
			var choose = await _chooseRepository.GetByIdAsync(id);
			if (choose is null)
			{
				throw new Exception("Choose Bulunmadı");
			}
			_chooseRepository.Delete(choose);
			await _unitOfWork.SaveChangesAsync();
		}
    }
}
