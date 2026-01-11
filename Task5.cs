using System;

namespace KamustaMundoApp
{
    // Student structure to store student information
    struct Student
    {
        public string Name;
        public int EnglishMarks;
        public int MathMarks;
        public int ComputerMarks;
        public int TotalMarks;
        public int Position;
    }

    class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any following key");
            
            // Get total number of students
            Console.Write("Enter Total Students : ");
            int totalStudents = Convert.ToInt32(Console.ReadLine());

            // Create array to store student information
            Student[] students = new Student[totalStudents];

            // Loop to get information for each student
            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Enter Student Name : ");
                students[i].Name = Console.ReadLine();

                // Get English marks with validation
                Console.Write("Enter English Marks (Out Of 100) : ");
                students[i].EnglishMarks = GetValidMarks();

                // Get Math marks with validation
                Console.Write("Enter Math Marks (Out Of 100) : ");
                students[i].MathMarks = GetValidMarks();

                // Get Computer marks with validation
                Console.Write("Enter Computer Marks (Out Of 100) : ");
                students[i].ComputerMarks = GetValidMarks();

                // Calculate total marks
                students[i].TotalMarks = students[i].EnglishMarks + 
                                        students[i].MathMarks + 
                                        students[i].ComputerMarks;

                Console.WriteLine("*********************************************");
            }

            // Sort students by total marks in descending order
            SortStudentsByTotal(students);

            // Assign positions based on sorted order
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Position = i + 1;
            }

            // Display Report Card
            Console.WriteLine("****************Report Card*******************");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine($"Student Name: {students[i].Name}, Position: {students[i].Position}, Total: {students[i].TotalMarks}/300");
            }
            Console.WriteLine("****************************************");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to validate and get marks (0-100)
        static int GetValidMarks()
        {
            int marks;
            while (true)
            {
                try
                {
                    marks = Convert.ToInt32(Console.ReadLine());
                    if (marks >= 0 && marks <= 100)
                    {
                        return marks;
                    }
                    else
                    {
                        Console.Write("Invalid! Marks must be between 0-100. Try again: ");
                    }
                }
                catch
                {
                    Console.Write("Invalid input! Please enter a number: ");
                }
            }
        }

        // Method to sort students by total marks in descending order
        static void SortStudentsByTotal(Student[] students)
        {
            // Bubble sort - descending order
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - i - 1; j++)
                {
                    if (students[j].TotalMarks < students[j + 1].TotalMarks)
                    {
                        // Swap students
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }
    }
}
