using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIMS.Data;
using PIMS.Dtos;
using PIMS.Models;

namespace PIMS.Service
{
   public  class CountryService : ICountryService
    {
        private ApplicationDbContext _context;

        public CountryService(ApplicationDbContext context )
        {
            this._context = context;
        }

        public List<CountryDto> GetAll()
        {
            var CountryList = _context.Countries.ToList();
            List<CountryDto> countryDtos = new List<CountryDto>();
            foreach (var country in CountryList)
            {
                CountryDto countryDto = new CountryDto
                {
                    Id = country.Id,
                    Name = country.Name,
                    Continent = country.Continent,
                    CountryCode = country.CountryCode

                };
                countryDtos.Add(countryDto);

            }

            return countryDtos;

        }

    }
}
