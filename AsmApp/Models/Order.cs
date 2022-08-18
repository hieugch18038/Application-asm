﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System;

namespace AsmApp.Models
{
    public class Order
    {

        public int Id { get; set; }

        public int BookId { get; set; }   //1 - many

        public Book Books { get; set; } 

        public string UserEmail { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public double OrderPrice { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
    }
}
