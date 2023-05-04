using System;
namespace GeneralStoreMVC.Models.Products
{
    public class ProductCreateModel
    {
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
    }
}

