using ChuschkaPolya.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChuschkaPolya.Models
{
    public class UsersVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This is mandatory!")]
        [EnumDataType(typeof(RolesType))]
        public RolesType Roles { get; set; }

        public List<SelectListItem> Orders { get; set; }
    }
}
