using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsMiniProject
{
    internal class Student
    {
        String Name = "";
        int Age;
        Char Grade;

        internal Student(String name, int age, Char grade)
        {
            if (age <= 5)
                throw new ArgumentException("Age must be greater than 5.");

            Name = name;
            Age = age;
            Grade = grade;
        }
        internal void DisplayDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Age  :" + Age);
            Console.WriteLine("Grade:" + Grade);
            Console.WriteLine("-------------------");
        }
    }
}
