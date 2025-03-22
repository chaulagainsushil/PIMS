using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PIMS.Models
{
    public class LocalBodyType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
