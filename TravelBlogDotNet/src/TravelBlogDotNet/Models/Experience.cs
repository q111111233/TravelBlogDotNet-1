using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlogDotNet.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int id { get; set; }
        public int location_id { get; set; }
        public string description { get; set; }
    }
}
