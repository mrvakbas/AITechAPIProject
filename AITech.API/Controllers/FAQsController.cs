using AITech.Business.Services.FAQServices;
using AITech.DTO.FAQDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController(IFAQService _fAQService) : ControllerBase
    {
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var faq = await _fAQService.TGetAllAsync();
			return Ok(faq);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var faq = await _fAQService.TGetByIdAsync(id);
			return Ok(faq);
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateFAQDto fAQDto)
		{
			await _fAQService.TCreateAsync(fAQDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFAQDto fAQDto)
        {
            await _fAQService.TUpdateAsync(fAQDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _fAQService.TDeleteAsync(id);
            return NoContent();
        }
    }
}
