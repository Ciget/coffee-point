using CS.CoffeePoint.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS.CoffeePoint.Controllers
{
    [Route("api/[controller]")]
    public class PlaceController : Controller
    {
        private readonly IPlaceService _placeService;

        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        public IActionResult Get()
        {
            return Ok(_placeService.GetList());
        }
    }
}
