using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlogDotNet.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int ExperienceId { get; set; }
        public int LocationId { get; set; }
        public string Description { get; set; }
    }
}
