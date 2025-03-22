using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace PIMS.Models
{
    public class PrisonInfromation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int  LocalBodyId { get; set; }
        public int AreaId { get; set; }
        public string WardenName { get; set; }
        public string WardenContact { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }
        public string PrisonContact { get; set; }

        [ForeignKey("LocalBodyId")]
        public LocalBody LocalBody { get; set; }

        [ForeignKey("AreaId")]
        public Area Area { get; set; }

    }
}
