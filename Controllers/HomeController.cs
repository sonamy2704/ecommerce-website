using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;
using System.Collections.Generic;

namespace ECommerceApp.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m, Description = "High performance laptop" },
            new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Description = "Latest model smartphone" }
        };

        public IActionResult Index()
        {
            return View(Products);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = Products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
