using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Data.Base;

namespace ebook_cw.Models
{
    public class Writter : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Writer's Name is Required!")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Profile Image is Required!")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Writer's Biography is Required!")]
        public string Bio { get; set; }

        //relationships
        public List<Writter_Book> Writter_Books { get; set; }

    }
}


