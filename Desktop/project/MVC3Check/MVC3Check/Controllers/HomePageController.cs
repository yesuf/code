using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3Check.Models;
namespace MVC3Check.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/

       public ActionResult ProductList()
        {
       

           List<ProductNameroduct> productLst = new List<ProductNameroduct>{
        new ProductNameroduct{ProductId="P01",ProductName="Pen",Quantity=10,Price=12},
   
    
    };
    return View("ProductLst",ProductList());
}
        }


    }


