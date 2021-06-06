using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCProject1.Models;
namespace MVCProject1.Controllers
{
    public class ProductsController : Controller
    {

        public List<ProductModel> ps = new List<ProductModel>();

        public ProductsController()
        {
            this.ps.Add(new ProductModel() { id = 1, name = "Dell 14", description = "Dell 14 5000 14 Full HD 2 -in-1 Laptop(512GB)[i7 11th Gen]", image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/5/555184.jpg?1" });
            this.ps.Add(new ProductModel() { id = 2, name = "Alienware", description = "Alienware M17 R3 17.3 Full HD 300Hz Gaming Laptop(Intel i7)[RTX 2070]", image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/6/561564.jpg?1" });
            this.ps.Add(new ProductModel() { id = 3, name = "Microsoft", description = "Microsoft Surface Laptop 4 13.5 Ryzen 5 256GB / 8GB(Platinum)", image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/5/554489.jpg?1" });

        }

        // 
        // GET: /products/
        public IActionResult Index(string color = "")
        {



            ViewData["color"] = color;
            ViewData["ps"] = ps;
            return View();

        }



        // GET: /details/
        public IActionResult Details(int id)
        {
            ProductModel device = ps.Find(b => b.id == id);
            if (id == null)
            {
                return Content("NotFound");
            }
            else
            {


                ViewData["img"] = "https://cdn5.vectorstock.com/i/1000x1000/73/49/404-error-page-not-found-miss-paper-with-white-vector-20577349.jpg";
                ViewData["device"] = device;
                return View();
            }


        }



       
        public int calculateDiscount(int bill, int dis)
        {
            int afterDiscount = bill - (bill * dis / 100);

        //     Enter bill amount: 5000
        //     Enter discount percentage: 10
        //     After discount your bill is: 4500
            return afterDiscount;
        }



        public int percentage(int yourNumber, int totalNumber)
        {

            int percentComplete = (int)Math.Round((double)(100 * yourNumber) / totalNumber);

            return percentComplete;
        }


        
          

       



    }
}
