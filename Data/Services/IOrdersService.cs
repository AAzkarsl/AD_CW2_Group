using ebook_cw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ebook_cw.Data.Services
{
    public interface IOrdersService
    {
        Task<Order> StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress, ApplicationUser user);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
        Task<List<Order>> GetOrdersAsync();
        Task<Order> GetOrdersByUserIdOrderIDAsync(string userId, int OrderId, string userRole);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
        Task AddFeedbackToOrderAsync(int orderId, Feedback feedback);
    }

}
