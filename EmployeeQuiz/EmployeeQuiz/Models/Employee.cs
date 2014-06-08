using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace EmployeeQuiz.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "El numero del vehiculo no ha sido encon")]
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Estacionamiento { get; set; }
        public double Precio { get; set; }
        public string PhotoPath { get; set; }
        public string Photo { get; set; }
        //Un modelo son datos
    }
}