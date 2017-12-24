﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<Review> Reviews { get; set; }

        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
    }
}
