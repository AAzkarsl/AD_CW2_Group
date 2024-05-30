using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ebook_cw.Models;
using Microsoft.EntityFrameworkCore;
using ebook_cw.Data.Cart;
using ebook_cw.Data.Enums;
using ebook_cw.Data.Services;

namespace ebook_cw.Controllers;

public class HomeController : Controller
{

    private readonly IBooksService _service;

    public HomeController(IBooksService service)
    {
        _service = service;
    }

    [Route("/", Name = "Home")]
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAll(n => n.Publisher);
        var newBooks = await _service.NewBooks();
        ViewBag.newBooks = newBooks;
        return View();
    }

    [HttpGet]
    [Route("/notfound")]
    public ActionResult AccessDenied()
    {
        return View("NotFound");
    }

    [Route("/book/{slug}", Name = "BookView")]
    public async Task<IActionResult> BookView(string slug)
    {
        //var data = await _service.GetBookByIdAsync(id);
        var data = await _service.GetBookBySlugAsync(slug);
        ViewBag.count = _service.GetBookCount();
        if (data == null) return View("NotFound");
        return View("BookView", data);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var error = new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier };
        return View("Error", error);
    }



    [Route("books", Name = "Shop")]
    public async Task<IActionResult> Shop(int? page, string search, string category)
    {
        var data = await _service.GetAllDescAsync();

        if (page > 0)
        {
            page = (int)page;

        }
        else
        {
            page = 1;
        }
        var filteredResult = data;
        if (!string.IsNullOrEmpty(search))
        {
            ViewBag.search = search;
            ViewBag.category = null;
            //filteredResult = data.Where(n =>n.Name.Contains(search) || n.Description.Contains(search)).ToList();
            filteredResult = data.Where(n => n.Name.ToLower().Contains(search.ToLower()) || n.Description.ToLower().Contains(search.ToLower())).ToList();
        }
        else if (!string.IsNullOrEmpty(category))
        {
            //var cat = Enum.GetName(typeof(BookCategory), category);
            //if(cat == null) return View("NotFound");

            var catid = Enum.GetNames(typeof(BookCategory)).Any(x => x == category);

            if (catid)
            {
                BookCategory enumData = (BookCategory)Enum.Parse(typeof(BookCategory), category);
                filteredResult = data.Where(n => n.BookCategory == enumData).ToList();
            }
            else
            {
                filteredResult = data.Where(n => n.BookCategory == 0).ToList();
            }

            ViewBag.category = category;
            ViewBag.catid = catid;
            ViewBag.search = null;
            //filteredResult = filteredResult;

        }
        else
        {
            ViewBag.search = null;
            filteredResult = data;
        }
        int limit = 18;
        int start = (int)(page - 1) * limit;
        int totalProduct = filteredResult.Count();
        int pageNumber = totalProduct / limit;
        ViewBag.totalProduct = totalProduct;
        ViewBag.currentpage = page;
        ViewBag.pageNumber = pageNumber;
        ViewBag.limit = limit;

        ViewBag.count = _service.GetBookCount();

        var products = filteredResult.OrderByDescending(s => s.Id).Skip(start).Take(limit).ToList();

        return View("shop", products);
    }




}
