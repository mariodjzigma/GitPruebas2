using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace EmployeeQuiz.Models
{
    public class PayrollDm
    {
        //
        List<Employee> empList;

        //Constructor del modelo
        public PayrollDm(string dbPath)
        {
            
            //leer un archivo
            empList = new List<Employee>();

            var reader = new StreamReader(
                File.OpenRead(dbPath));

            //Parsear
            while (!reader.EndOfStream)
            { 
               //leo una linea
                var line = reader.ReadLine();

                //Parsear
                //Separar valores y guardarlos en un objeto
                var valores = line.Split(',');
                empList.Add(
                    new Employee 
                    {
                        Id = valores[0],
                        Marca = valores[1],
                        Modelo = valores[2],
                        Color = valores[3],
                        Estacionamiento = valores[4],
                        Precio = double.Parse(valores[5]),
                        PhotoPath = valores[6],
                        Photo = valores[7]
                       

                    
                    }
                    );
            }


        }

        //accesor
        public Employee GetEmployeeById(string id)
        {
            /*Employee null;
            foreach (var empleadin in empList)
            {
             if (id == empleadin.Id)
             {
             emp = empleadin;
             }
             }
             
            return emp;*/
            var emp = empList.Find(e => e.Id == id);
            return emp;
        }

    }
}