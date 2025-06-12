using KMNShop.Catalog.Dtos.BannerDtos;
using KMNShop.Catalog.Services.BannerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannersController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBanners()
        {
            var banners = await _bannerService.GetAllBannerAsync();

            return Ok(banners);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBannerById(string id)
        {
            var banner = await _bannerService.GetByIdBannerAsync(id);

            return Ok(banner);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            await _bannerService.CreateBannerAsync(createBannerDto);

            return Ok("Banner created successfully.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            await _bannerService.UpdateBannerAsync(updateBannerDto);

            return Ok("Banner updated successfully.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBanner(string id)
        {
            await _bannerService.DeleteBannerAsync(id);

            return Ok("Banner deleted successfully.");
        }
    }
}
