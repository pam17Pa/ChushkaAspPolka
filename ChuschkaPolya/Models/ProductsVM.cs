﻿using ChuschkaPolya.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChuschkaPolya.Models
{
    public class ProductsVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public decimal Price { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public TypeProduct Type { get; set; }

        public ICollection<SelectListItem> Orders { get; set; }
    }
}
