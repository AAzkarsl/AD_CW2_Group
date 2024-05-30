using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ebook_cw.Data.Cart;
using ebook_cw.Data.ViewModels;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using ebook_cw.Data.Services;
using ebook_cw.Models;

namespace ebook_cw.Controllers
{
    [Route("admin")]
    [Authorize(Roles = "Admin")]
    public class AdminOrdersController : Controller
    {
        private readonly IBooksService _booksService;
        private readonly IOrdersService _ordersService;

        public AdminOrdersController(IBooksService booksService, IOrdersService ordersService)
        {
            _booksService = booksService;
            _ordersService = ordersService;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("lk-LK");
        }


        [Route("orders")]
        public async Task<IActionResult> Orders()
        {
            var orders = await _ordersService.GetOrdersAsync();
            return View("orders", orders);
        }

        [Route("orders/edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var order = await _ordersService.GetOrderByIdAsync(id);
            if (order == null) return View("NotFound");
            return View(order);
        }

        [HttpPost]
        [Route("orders/edit/{id}")]
        public async Task<IActionResult> Edit(int id, Order order)
        {
            if (id != order.Id) return View("NotFound");

            if (ModelState.IsValid)
            {
                await _ordersService.UpdateOrderAsync(order);
                return RedirectToAction(nameof(Orders));
            }
            return View(order);
        }


        [Route("/orders/delete/{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var book = await _ordersService.GetOrderByIdAsync(id);
            if (book == null) return View("NotFound");
            await _ordersService.DeleteOrderAsync(id);
            return RedirectToAction(nameof(Orders));
        }


        [Route("orders/confirmed/{id}")]
        public async Task<IActionResult> OrderConfirmed(int id)
        {
            var order = await _ordersService.GetOrderByIdAsync(id);
            if (order == null) return View("NotFound");
            return View(order);
        }

        [Route("orders/details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var order = await _ordersService.GetOrderByIdAsync(id);
            if (order == null) return View("NotFound");
            return View(order);
        }


    }
}
