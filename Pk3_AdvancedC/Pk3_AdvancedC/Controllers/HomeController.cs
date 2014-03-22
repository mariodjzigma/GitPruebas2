using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk3_AdvancedC.Models;

namespace Pk3_AdvancedC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            return "Navegar a una URL para mostrar un ejemplo";
        }

        public ViewResult AutoProperty();
        ProductID = 12,
        Name = "kayak",
        Description =  "Kiosteca Blue",
        Category = "SPORTS",
        Price = 12.5

        { 

            
        //Crear un nuevo objeto
            //De la clase producto
           /* Product myProduct  = new Product();

            //Establece el vlor de la propiedad
            myProduct.ProductID = 12;
            myProduct.Name = "Kayak";
            myProduct.Description = "kiosteca blue";
            myProduct.Category = "SPORT";
            myProduct.Price = 12.5F;

            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                myProduct.ProductID,
                 myProduct.Name,
                 myProduct.Description,
                 myProduct.Category,
                 myProduct.Price);

            //obtiene la propiedad
            //string productsName = myProducts.Name;

            //genera la vista
            return View("Result",
               (object)salida);
            
        
        }

    }
}
