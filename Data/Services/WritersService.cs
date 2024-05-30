//using ebook_cw.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ebook_cw.Data.Base;
using ebook_cw.Data;
using ebook_cw.Models;


namespace ebook_cw.Data.Services
{
    public class WritersService : EntityBaseRepository<Writter>, IWritersService
    {

        public WritersService(AppDbContext context) : base(context) { }



    }
}
