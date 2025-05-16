using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;

class Program
{       
        struct Student{
           public string Surname;
           public string Name;
           public int SchoolNumber;
           public int Marks;

           public Student(string surname, string name, int schoolNumber, int marks){

            Surname = surname;
            Name = name;
            SchoolNumber = schoolNumber;
            Marks = marks;

           }

        }

        static void Main(string[] args)
        {
          int count = int.Parse(Console.ReadLine());
          List <Student> students = new List <Student>();

          for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            string surname = input[0];
            string name = input[1];
            int schoolNumber = int.Parse(input[2]);
            int marks = int.Parse(input[3]);

        }
    }    

   
}