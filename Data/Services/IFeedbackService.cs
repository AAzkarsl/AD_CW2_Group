using ebook_cw.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ebook_cw.Data.Services
{
    public interface IFeedbackService
    {
        Task<IEnumerable<Feedback>> GetAllFeedbacksAsync();
        Task<IEnumerable<Feedback>> GetFeedbacksByBookIdAsync(int bookId);
        Task<Feedback> GetFeedbackByIdAsync(int id);
        Task AddFeedbackAsync(Feedback feedback);
        Task DeleteFeedbackAsync(int id);
    }
}
