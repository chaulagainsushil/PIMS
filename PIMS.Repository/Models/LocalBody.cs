using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMS.Models
{
    public class LocalBody
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocalBodyId { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("LocalBodyId")]
        public LocalBodyType LocalBodyType { get; set; }
        
        [ForeignKey("DistrictId")]
        public District District { get; set; }


    }
}
