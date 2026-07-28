namespace ConsoleAppStudentResult2
{
    public class Program : Methods
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========Welcome to the Student Dashboard=======");
                Console.WriteLine();
                Console.WriteLine("Choose one:");
                Console.WriteLine("=============================");
                Console.WriteLine();
                Console.WriteLine("1. Create a Student");
                Console.WriteLine("2. Display the students");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. Search by ID");
                Console.WriteLine("5. Search by Name");
                Console.WriteLine("6. Filter Passed Students");
                Console.WriteLine("7. Filter Failed Students");
                Console.WriteLine("8. Delete a Student");
                Console.WriteLine("9. Show Highest Mark, Lowest Mark");
                Console.WriteLine("10. Filter By Grade");
                Console.WriteLine("11. Sort By Marks");
                Console.WriteLine("12. Show the Top Performer");
                Console.WriteLine("13. Show the Good Students");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.WriteLine("=============================");
                Console.Write("Enter your Choice here: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: 
                        AddStudent();
                        break;
                    case 2:
                        DisplayStudent(students);
                        break;
                    case 3: 
                        EditStudent();
                        break;
                    case 4:
                        SearchById();
                        break;
                    case 5: 
                        SearchByName();
                        break;
                    case 6:
                        PassedStudents();
                        break;
                    case 7:
                        FailedStudents();
                        break;
                    case 8:
                        RemoveStudent();
                        break;
                    case 9: 
                        HighLowMark();
                        break;
                    case 10:
                        FilterGrade();
                        break;
                    case 11:
                        SortMarks();
                        break;
                    case 12:
                        TopPerformer();
                        break;
                    case 13:
                        GoodStudents();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        Console.WriteLine("Press Any Key To Continue.....");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
