using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStudentResult2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Biology { get; set; }
        public int Math {  get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        public string LetterGrade { get; set; }
        public double cgpa { get; set; }
        public bool IsPassed { get; set; }
    }
}
