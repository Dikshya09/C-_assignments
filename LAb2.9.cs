using System;
namespace Lab2Q9
{ 
    class Person1
    {
        private string name;
        private int age;
        private string message;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Message
        {
            set { message = value; }
        }

        public string Address { get; set; }
        public Person1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {

            Console.WriteLine($"updated Name: {Name}");
            Console.WriteLine($" updated Age: {Age}");
            Console.WriteLine($" readonly Address: {Address}");
        }
    }

    class Program1234
    {
        /*static void Main()
        {
            Person1 person = new Person1("pramila", 25);
            person.Name = "Dikshya Shahi";  // Setting name
            //writeonly
            person.Message = "Hello my name is Dikshya Shahi";
            person.Address = "sankhu, kathmandu";
            person.DisplayInfo();
            Console.ReadKey();
        }*/
    }
}