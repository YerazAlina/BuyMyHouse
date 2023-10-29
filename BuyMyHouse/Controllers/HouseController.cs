using BuyMyHouse.DAL;
using DAL.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuyMyHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly BuyMyHouseDbContext _buyMyHouseDbContext;

        public HouseController(BuyMyHouseDbContext buyMyHouseDbContext)
        {
            _buyMyHouseDbContext = buyMyHouseDbContext;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAllHouses()
        {
            return Ok(_buyMyHouseDbContext);
        }
    }
}