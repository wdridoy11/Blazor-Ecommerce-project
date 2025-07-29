﻿using BlazorEcommerce.Data;

namespace BlazorEcommerce.Repository.IRepository
{
    public interface ICartRepository
    {
        public Task<bool> UpdateCartAsync(string userId, int productId, int updateBy);
        public Task<IEnumerable<ShoppingCart>> GetAllAsync(string? userId);
        public Task<bool> ClearCartAsync(string? userId);
        public Task<int> GetTotalCartCountAsync(string? userId);
        public Task<bool> DeleteAsync(int id);
    }
}
