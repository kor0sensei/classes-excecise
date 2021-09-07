using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<Employee>();
             // Create three employees
            var employee1 = new Employee("Maka", "Alburn", "Scythe Meister", new DateTime(2021, 09, 07));
            var employee2 = new Employee("Eren", "Yeager", "Attack Titan", new DateTime(2021, 09, 08));
            var employee3 = new Employee("Takemichi", "Hanagaki", "Gang Member", new DateTime(2021, 09, 09));

            // Assign the employees to the company
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            // Create an instance of a company. Name it whatever you like.

            var Anime = new Company("CrunchyRoll", new DateTime(2021, 08, 21), employeeList);
            Anime.ListEmployees();
        }
    }
}