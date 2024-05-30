using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Data.Base;
using ebook_cw.Data.Enums;

namespace ebook_cw.Models
{
    public class Book : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string PublishDate { get; set; }
        //enom
        public BookCategory BookCategory { get; set; }
        //Relationships
        public List<Writter_Book> Writter_Books { get; set; }
        //Publisher
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }

        // Feedback relationship
        public List<Feedback> Feedbacks { get; set; }

    }
}


