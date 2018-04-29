
using CS.CoffeePoint.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS.CoffeePoint.Controllers
{
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
