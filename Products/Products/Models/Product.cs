﻿namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CategoryId { get; set; }
     public   Category Category { get; set; }
    }
}
