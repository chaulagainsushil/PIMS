using System.ComponentModel.DataAnnotations;

namespace PIMS.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public String Continent { get; set; }
        public string CountryCode { get; set; }
    }
}
