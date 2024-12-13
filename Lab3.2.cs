using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_2
{
    // Employee class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John", Salary = 60000, Address = "Kathmandu" },
                new Employee { Id = 2, Name = "Alice", Salary = 45000, Address = "Kathmandu" },
                new Employee { Id = 3, Name = "Bob", Salary = 70000, Address = "Pokhara" },
                new Employee { Id = 4, Name = "Dikshya", Salary = 80000, Address = "Kathmandu" },
                new Employee { Id = 5, Name = "Emma", Salary = 30000, Address = "Lalitpur" }
            };

            // LINQ query to filter employees
            var selectedEmployees = employees
                .Where(emp => emp.Salary > 50000 && emp.Address == "Kathmandu")
                .ToList();

            // Display the results
            Console.WriteLine("Employees with salary > 50000 and address in Kathmandu:");
            foreach (var employee in selectedEmployees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}");
                Console.ReadLine();
            }
        }
    }
}
