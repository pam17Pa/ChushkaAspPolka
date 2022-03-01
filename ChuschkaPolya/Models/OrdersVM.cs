using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChuschkaPolya.Models
{
    public class OrdersVM
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        [Required(ErrorMessage = "This is mandatory!")]
        public List<SelectListItem> Products { get; set; }

        public int UserId { get; set; }
        [Required(ErrorMessage = "This is mandatory!")]
        public List<SelectListItem> Users { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of order")]
        public DateTime OrderDate { get; set; }
    }
}
