
using Microsoft.AspNetCore.Mvc;
using prac6.Models;
using System.Collections.Generic;
using System.Linq;

namespace prac6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> p = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High performance laptop",
                    Price = 55000,
                    Category = "Electronics",
                    Image = "laptop.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Description = "Smart mobile phone",
                    Price = 25000,
                    Category = "Electronics",
                    Image = "mobile.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Wireless headphones",
                    Price = 2000,
                    Category = "Accessories",
                    Image = "headphones.jpg"
                }
            };

            return View(p);
        }

        public IActionResult Details(int id)
        {
            List<Product> p = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High performance laptop",
                    Price = 55000,
                    Category = "Electronics",
                    Image = "laptop.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Description = "Smart mobile phone",
                    Price = 25000,
                    Category = "Electronics",
                    Image = "mobile.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Wireless headphones",
                    Price = 2000,
                    Category = "Accessories",
                    Image = "headphones.jpg"
                }
            };

            Product? product = p.Find(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
