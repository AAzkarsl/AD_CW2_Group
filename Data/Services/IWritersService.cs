//using ebook_cw.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Data.Base;
using ebook_cw.Models;

namespace ebook_cw.Data.Services
{
    public interface IWritersService : IEntityBaseRepository<Writter>
    {
        // IEnumerable<Writter> GetAll();
        // Task<Writter> GetById(int id);
        // void Add(Writter writter);
        // Task<Writter> UpdateAsync(int id, Writter newWritter);
        // void Delete(int Id);
    }
}
