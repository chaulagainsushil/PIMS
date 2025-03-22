using System.ComponentModel.DataAnnotations;

namespace PIMS.Dtos
{
    public class ProvinceDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
