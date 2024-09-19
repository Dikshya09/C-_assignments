using System;
namespace lab2Q1
{
    class Employee
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }


        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}");
        }


        static void Main()
        {
            Employee emp = new Employee("Dikshya Shahi", "dikshyashahi977.com", 89000);
            emp.DisplayEmployeeInfo();
            Console.ReadKey();
        }
    }
}