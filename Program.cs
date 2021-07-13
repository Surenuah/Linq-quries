using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department(){ Id = 3, Country = "France", City = "Paris" },
                new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee(){ Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee(){ Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee(){ Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 3 },
                new Employee(){ Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee(){ Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee(){ Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4 }
            };

            /* Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 
            23 года*/

            var employeesAges = from Department in departments
                                join Employee in employees 
                                on new (Department.City)
                                equals new (Employee.Age)
                                

            foreach(var e in employeesAges)
            {
                Console.WriteLine(employeesAges);
            }

            // Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.

            //var ageEmployees = employees.Where(x => x.Age > 25).GroupBy(x => x.Id).Select(x => x.FirstOrDefault());

            //foreach(var a in ageEmployees)
            //{
            //    Console.WriteLine(ageEmployees);
            //}

            // Вывести список стран без повторений.
            //var distinctCountries = departments.GroupBy(x => x.Country);

            //foreach(var d in distinctCountries)
            //{
            //    Console.WriteLine(distinctCountries);
            //}

            // Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.
            //var selectedDepartments = departments.Select(x => x.Country = "Ukraine");

            //foreach(var temp in selectedDepartments)
            //{
            //    Console.WriteLine(selectedDepartments);
            //}
        }
    }
}
