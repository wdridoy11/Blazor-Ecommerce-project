﻿namespace BlazorEcommerce.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? SpecialTag { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal? StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string? ImageUrl { get; set; }
    }
}
