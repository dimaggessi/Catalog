﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(80, ErrorMessage = "Name must be between 5 and 20 characters.",
            MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Description maximum length {1} characters.")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(8,2")]
        [Range(1, 10000, ErrorMessage = "Price must be between {1} and {2}.")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 10)]
        public string ImageUrl { get; set; }

        public float Stock { get; set; }

        public DateTime Date { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}