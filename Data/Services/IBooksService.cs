using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Data.Base;
using ebook_cw.Data.ViewModels;
using ebook_cw.Models;

namespace ebook_cw.Data.Services
{
    public interface IBooksService : IEntityBaseRepository<Book>
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<Book> GetBookBySlugAsync(string slug);
        Task<Book> SlugCheck(string slug);

        Task<IEnumerable<Book>> NewBooks();
        Task<IEnumerable<Book>> GetAllDescAsync();

        Task<NewBookDropdownsVM> GetNewBookDropdownsValues();

        Task AddNewBookAsync(NewBookVM data);
        Task UpdateBookAsync(NewBookVM data);

        IEnumerable<BookCategoryCountData> GetBookCount();

        Task DeleteBookAsync(Book data);

        Task<IEnumerable<BookReportViewModel>> GetAllBooksReportAsync();

    }
}
