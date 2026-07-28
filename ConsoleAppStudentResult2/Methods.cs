using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStudentResult2
{ 
    public class Methods
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent()
        {
            try
            {


                Student student = new Student();
                Console.Clear();

                Console.Write("ID : ");
                student.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name : ");
                student.Name = Console.ReadLine()!;

                Console.Write("Physics : ");
                student.Physics = Convert.ToInt32(Console.ReadLine());

                Console.Write("Chemistry : ");
                student.Chemistry = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biology : ");
                student.Biology = Convert.ToInt32(Console.ReadLine());

                Console.Write("Math : ");
                student.Math = Convert.ToInt32(Console.ReadLine());

                student.Total = student.Physics + student.Chemistry + student.Math + student.Biology;
                student.Average = student.Total / 4.0;

                CalculateMarks(student);

                students.Add(student);

                Console.WriteLine("\nStudent Added Successfully.");
                Console.ReadKey();
            }
            catch 
            {
                Console.WriteLine("Error... Try Again");
            }
        }
        public static void RemoveStudent()
        {
            Console.Clear();
            Console.Write("Enter ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = students.FirstOrDefault(x => x.Id == id)!;

            if (student == null)
            {
                Console.WriteLine("Student Not Found.");
            }
            else
            {
                students.Remove(student);
                Console.WriteLine("Removed Successfully.");
            }

            Console.ReadKey();
        }
        public static void DisplayStudent(List<Student> list)
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("No Student Found.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"\tID\tName\t\tTotal Marks\t\tAverage Marks\t\tLetterGrade\t\tCGPA");
            Console.WriteLine("================================================================================================================");
            foreach (Student s in list)
            {
                Console.WriteLine($"\t{s.Id}\t{s.Name}\t\t{s.Total}\t\t\t{s.Average:F2}\t\t\t{s.LetterGrade}\t\t\t{s.cgpa}");
                Console.WriteLine();
            }
            Console.WriteLine("================================================================================================================");

            Console.ReadKey();
        }
        public static void EditStudent()
        {
            try
            {
                Console.Clear();
                Console.Write("Enter ID : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Student student = students.FirstOrDefault(x => x.Id == id)!;

                if (student == null)
                {
                    Console.WriteLine("Student Not Found.");
                    Console.ReadKey();
                    return;
                }

                Console.Write("New Name : ");
                student.Name = Console.ReadLine()!;

                Console.Write("Physics : ");
                student.Physics = Convert.ToInt32(Console.ReadLine());

                Console.Write("Chemistry : ");
                student.Chemistry = Convert.ToInt32(Console.ReadLine());

                Console.Write("Math : ");
                student.Math = Convert.ToInt32(Console.ReadLine());
                Console.Write("Biology: ");
                student.Biology = Convert.ToInt32(Console.ReadLine());

                student.Total = student.Physics + student.Chemistry + student.Math + student.Biology;
                student.Average = student.Total / 4.0;

                CalculateMarks(student);

                Console.WriteLine("Updated Successfully.");
                Console.ReadKey();
            }
            catch
            { Console.WriteLine("Error. Try Again..."); }
        }
        public static void SearchById()
        {
            Console.Clear();
            Console.Write("Enter ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = students.FirstOrDefault(x => x.Id == id)!;

            if (student == null)
            {
                Console.WriteLine("Not Found.");
                Console.ReadKey();
                return;
            }

            DisplayStudent(new List<Student> { student });
        }
        public static void SearchByName()
        {
            Console.Clear();
            Console.Write("Enter Name : ");
            string name = Console.ReadLine()!;

            List<Student> result = students
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .ToList();

            DisplayStudent(result);
        }
        public static void PassedStudents()
        {
            Console.Clear();
            DisplayStudent(students.Where(x => x.IsPassed).ToList());
        }
        public static void FailedStudents()
        {
            Console.Clear();
            DisplayStudent(students.Where(x => !x.IsPassed).ToList());
        }

        public static void HighLowMark()
        {
            Console.Clear();
            if (students.Count == 0)
            {
                Console.WriteLine("No Data.");
            }
            else
            {
                Console.WriteLine($"Highest Average : {students.Max(x => x.Average):F2}");
                Console.WriteLine($"Lowest Average : {students.Min(x => x.Average):F2}");
                Console.WriteLine($"Average Average : {students.Average(x => x.Average):F2}");
            }

            Console.ReadKey();
        }
        public static void FilterGrade()
        {
            Console.Clear();
            Console.Write("Enter Grade : ");
            string grade = Console.ReadLine()!;

            List<Student> result = students
                .Where(x => x.LetterGrade.Equals(grade, StringComparison.OrdinalIgnoreCase))
                .ToList();

            DisplayStudent(result);
        }
        public static void SortMarks()
        {

            Console.Clear();
            List<Student> result = students
                .OrderByDescending(x => x.Average)
                .ToList();

            DisplayStudent(result);
        }
        public static void TopPerformer()
        {
            Console.Clear();
            if (students.Count == 0)
            {
                Console.WriteLine("No Data.");
                Console.ReadKey();
                return;
            }

            Student top = students
                .OrderByDescending(x => x.Average)
                .First();

            DisplayStudent(new List<Student> { top });
        }
        public static void GoodStudents()
        {
            Console.Clear();
            if (students.Count == 0)
            {
                Console.WriteLine("No Data.");
                Console.ReadKey();
                return;
            }

            double avg = students.Average(x => x.Average);

            List<Student> result = students
                .Where(x => x.Average > avg)
                .ToList();

            Console.WriteLine($"Overall Average = {avg:F2}");

            DisplayStudent(result);
        }
        public static void CalculateMarks(Student student)
        {
            double avg = student.Average;
            Console.Clear();

            if (avg >= 80)
            {
                student.LetterGrade = "A+";
                student.cgpa = 4.00;
            }
            else if (avg >= 70)
            {
                student.LetterGrade = "A";
                student.cgpa = 3.75;
            }
            else if (avg >= 60)
            {
                student.LetterGrade = "A-";
                student.cgpa = 3.50;
            }
            else if (avg >= 50)
            {
                student.LetterGrade = "B";
                student.cgpa = 3.00;
            }
            else if (avg >= 40)
            {
                student.LetterGrade = "C";
                student.cgpa = 2.00;
            }
            else
            {
                student.LetterGrade = "F";
                student.cgpa = 0;
            }

            student.IsPassed = avg >= 40;
        }
    }
}
