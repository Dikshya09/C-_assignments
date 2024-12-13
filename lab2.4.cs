using System;

namespace Lab2Q4
{
    class Member
    {
        private int id;
        private string name;

        public Member(int i, string n)
        {
            id = i;
            name = n;
        }
        public void PrintDetails()
        {
            Console.WriteLine("ID: {0} \nName : {1}", id, name);
        }
    }
    //single level
    class Teacher : Member
    {
        private string panno;
        public Teacher(int i, string n, string pan) : base(i, n)
        {
            panno = pan;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Pan No: {0}", panno);
        }
    }
    //multilevel
    class BCATeacher : Teacher
    {
        private bool isTechnical;
        public BCATeacher(int i, string n, string pan, bool it) : base(i, n, pan)
        {
            isTechnical = it;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Is Technical: {0}", isTechnical);
        }
    }
    //hierarchical
    class Student : Member
    {
        private string rollno;
        public Student(int i, string n, string roll) : base(i, n)
        {
            rollno = roll;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Roll No: {0}", rollno);
        }
    }
    internal class InheritDemo
    {
          static void Main(string[] args)
          {
              Teacher t = new Teacher(120, "Ram", "2154545");
              t.PrintDetails();

              Student s = new Student(120, "sita", "646454");
              s.PrintDetails();

              BCATeacher bt = new BCATeacher(120, "hari", "646454",false);
              bt.PrintDetails();
              Console.ReadKey();
          }
    }
}