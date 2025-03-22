using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMS.Models;
using PIMS.Service;

namespace PIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryService countryService;
        public CountryController(ICountryService iCountryService)
        {
            this.countryService = iCountryService;


        }
        [HttpGet]
        public IActionResult Get()
        {
            var Countries = countryService.GetAll();
            return Ok(Countries);
        }


    }
}
