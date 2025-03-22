using System.ComponentModel.DataAnnotations;

namespace PIMS.Models
{
    public class Area
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }

    }
}
