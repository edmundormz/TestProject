using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Core
{
    public class Toy
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Range(0,100)]
        public int AgeRestriction { get; set; }

        [Required]
        [MaxLength(50)]
        public string Company { get; set; }

        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }
    }
}
