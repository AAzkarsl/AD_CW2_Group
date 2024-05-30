using System;
using System.Collections.Generic;

namespace ebook_cw.Data.ViewModels
{
    public class OrderReportViewModel
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; } // Add this property
        public List<OrderItemViewModel> OrderItems { get; set; }
    }

    public class OrderItemViewModel
    {
        public string BookName { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}
