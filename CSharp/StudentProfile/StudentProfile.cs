namespace StudentProfile;

public class StudentProfile
{
    public static void Main(string[] args)
    {
        Student Louis = new Student("Louis", 19);
        Student Dei = new Student("Myrrh", "HirayaPutoMaya", 22, 11); // object has value

        Louis.DisplayInfo(); // the object and constructor you made are going to pass the fields to the method
        Console.WriteLine();
        Dei.DisplayInfo();

    } // end of main

    class Student
    {
        String name, section;
        int age, grade;


        public Student(String name, int age)
        {
            this.name = name;
            this.age = age;
            this.section = "Not Assigned";
            this.grade = -1;
        }
        public Student(String name, String section, int age, int grade)
        {
            this.name = name;
            this.section = section;
            this.age = age;
            this.grade = grade;
        }

        /* public void DisplayInfo()
        {
            
        } */
        public void DisplayInfo() // don't put any arguments so that the object can display their own fields
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            if (grade == -1)
            {
                Console.WriteLine($"Grade is not assigned");
            }
            else
            {
                Console.WriteLine($"Grade: {grade}");
            }
            Console.WriteLine($"Section: {section}");
        }
    } // end of class
} 