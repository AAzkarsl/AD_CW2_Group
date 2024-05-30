using System.ComponentModel.DataAnnotations;

namespace ebook_cw.Data.ViewModels
{
    public class FeedbackViewModel
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }
    }
}
