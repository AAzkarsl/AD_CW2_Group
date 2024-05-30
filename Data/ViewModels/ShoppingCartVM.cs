using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Models;
using ebook_cw.Data.Cart;

namespace ebook_cw.Data.ViewModels

{
    public class ShoppingCartVM
    {
        public ShoppingCart shoppingCart { get; set; }

        public double ShoppingCartTotal { get; set; }
    }
}
