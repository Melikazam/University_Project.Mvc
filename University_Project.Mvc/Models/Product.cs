﻿using System.ComponentModel.DataAnnotations;

namespace University_Project.Mvc.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
    }
}
