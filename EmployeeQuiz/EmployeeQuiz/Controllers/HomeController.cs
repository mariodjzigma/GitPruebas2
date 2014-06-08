using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeQuiz.Models;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        { 
          //creo el objeto de modelo de datos
            PayrollDm nomina = new PayrollDm(
                @"C:\Users\Zigma360\Documents\Visual Studio 2012\Projects\EmployeeQuiz\EmployeeQuiz\Models\daw.csv");
            
            //busco vehiculo dado su id
            var empleado = nomina.GetEmployeeById(emp.Id);
            if (ModelState.IsValid)
            {

                return View("WorkerView", empleado);
            }

            else
            {
                return View();
            
            }
        }


    }
}
