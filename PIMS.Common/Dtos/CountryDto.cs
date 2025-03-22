using System.ComponentModel.DataAnnotations;

namespace PIMS.Dtos
{
    public class CountryDto
    {


        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public String Continent { get; set; }
        [Required]
        public string CountryCode { get; set; }
    }
}
