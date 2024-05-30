using ebook_cw.Models;

namespace ebook_cw.Data.ViewModels
{
    public class BookDetailsViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Feedback> Feedbacks { get; set; }
        public FeedbackViewModel Feedback { get; set; }
    }
}
