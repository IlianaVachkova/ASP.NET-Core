using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Data.Models
{
    public class Car
    {
        public Car()
        {
            this.Parts = new HashSet<Part>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(0, long.MaxValue)]
        public long TravelledDistance { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
