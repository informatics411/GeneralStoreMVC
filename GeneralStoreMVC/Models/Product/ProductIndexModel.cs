﻿using System;
namespace GeneralStoreMVC.Models.Products
{
    public class ProductIndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
    }
}

