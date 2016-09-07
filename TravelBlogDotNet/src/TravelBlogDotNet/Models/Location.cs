using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlogDotNet.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int id { get; set; }
        public string Description { get; set; }
    }
}