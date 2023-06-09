﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace March13Practice
{
    class Program
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        // Create a data source by using collection initializer.
        static List<Student> students = new List<Student>
        {
          new Student {First="Svetlana", Last="Omelchenko", ID = 111, Scores = new List<int> {97, 92, 81, 60}},
          new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
          new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
          new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
          new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
          new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
          new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
          new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
          new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
          new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
          new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
          new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}},
          new Student {First="Obi-Wan", Last="Kenobi", ID=123, Scores= new List<int> {99, 100, 98, 99}}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# \n");

            // Create the query.
            // Note that the first line could also be written as "var studentQuery ="
            IEnumerable<Student> studentQuery =
              from student in students
                  //where student.Scores[0] > 90
              where student.Scores[0] > 90 && student.Scores[3] < 80 // This adds a second filter condition.
              select student;

            // Execute the query by using a foreach loop.
            // Note that var could also be used here.
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }

            var studentQuery2 =
              from student in students
              where student.Scores[0] > 97
              select student;

            Console.WriteLine("\nSecond Query: ");
            foreach (Student student in studentQuery2)
            {
                Console.WriteLine("{0}", student.First);
            }

            var query3 =
                from student in students
                where student.Scores[1] > 95
                select student;

            Console.WriteLine("\nHere is the third round of queries. ");
            foreach (Student student in query3)
            {
                Console.WriteLine("{0}", student.First);
            }
            Console.WriteLine("\n");
            var query4 =
                from student in students
                where student.Last[0] == 'M'
                select student;

            Console.WriteLine("4th query coming up: ");
            foreach (Student student in query4)
            {
                Console.WriteLine("{0}", student.Last);
            }

        }
    }
}
