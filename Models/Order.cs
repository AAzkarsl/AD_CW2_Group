using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ebook_cw.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Address Address { get; set; }

        public DateTime CreatedDate { get; set; } 

        public string OrderStatus { get; set; }

        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();


    }
}


