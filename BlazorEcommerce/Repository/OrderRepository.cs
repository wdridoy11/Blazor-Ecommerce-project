using BlazorEcommerce.Data;
using BlazorEcommerce.Repository.IRepository;

namespace BlazorEcommerce.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<OrderHeader> CreateAsync(OrderHeader orderHeader)
        {
            orderHeader.OrderDate = DateTime.Now;
            await _db.OrderHeader.AddAsync(orderHeader);
            await _db.SaveChangesAsync();
            return orderHeader;
        }

        public Task<IEnumerable<OrderHeader>> GetAllAsync(string? userId = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderHeader> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderHeader> GetOrderBySessionIdAsync(string sessionId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderHeader> UpdateStatusAsync(int orderId, string status, string paymentIntenId)
        {
            throw new NotImplementedException();
        }
    }
}
