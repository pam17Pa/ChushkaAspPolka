using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChuschkaPolya.Data
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Products Product { get; set; }

        public int UserId { get; set; }
        public virtual Users Users { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
