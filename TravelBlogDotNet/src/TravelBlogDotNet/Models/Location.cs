using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlogDotNet.Models
{
    [Table("Locations")]
    public class Location
    {
        public Location()
        {
           this.Experiences = new HashSet<Experience>();
        }
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}