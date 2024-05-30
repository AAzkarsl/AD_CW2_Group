using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Models;
using ebook_cw.Data.Base;
using Microsoft.EntityFrameworkCore;
using ebook_cw.Data.ViewModels;
using ebook_cw.Data.Enums;

namespace ebook_cw.Data.Services

{
    public class BookCategoryCountData
    {
        public BookCategory Category { get; set; }
        // public string BookgCategory { get; set; }
        public int Count { get; set; }
    }
}
