using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository _aboutRepository, IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task<List<ResultAboutDto>> TGetAllAsync()
        {
            var abouts = await _aboutRepository.GetAllAsync();
            return abouts.Adapt<List<ResultAboutDto>>();
        }

        public async Task<ResultAboutDto> TGetByIdAsync(int id)
        {
            var about = await _aboutRepository.GetByIdAsync(id);    
            if (about is null)
            {
                throw new Exception("Hakkımda Bulunamadı");
            } 
            return about.Adapt<ResultAboutDto>();
        }

        public async Task TCreateAsync(CreateAboutDto createDto)
        {
            var about = createDto.Adapt<About>();
            await _aboutRepository.CreateAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TUpdateAsync(UpdateAboutDto updateDto)
        {
            var about = updateDto.Adapt<About>();
            _aboutRepository.Update(about);
            await _unitOfWork.SaveChangesAsync();   
        }

        public async Task TDeleteAsync(int id)
        {
            var about = await _aboutRepository.GetByIdAsync(id);
            if (about is null)
            {
                throw new Exception("Hakkımda Bulunamadı");
            }
            _aboutRepository.Delete(about);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
