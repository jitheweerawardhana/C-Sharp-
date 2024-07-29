using Project1;

class Program
{
    static void Main(string[] args)
    {
        University university = new University("NSBM", "homagama");
        Department comSciDop = new Department("Computer Science", "CS");
        Professor profSmith = new Professor("Smith", "p123", "AI");
        Course aiCourse = new Course("AI", "A123", 40);
        Student studentTom = new Student("Tom", "1234", "CS");

        university.AddDepartment(comSciDop);
        comSciDop.AddProfessors(profSmith);
        comSciDop.AddStudent(studentTom);
        comSciDop.AddCourses(aiCourse);
        aiCourse.SetProfessor(profSmith);
        aiCourse.EnrolStudent(studentTom);

        GraduateStudent gradStudentAlice = new GraduateStudent("Alice", "222", "CS", "ML");
        comSciDop.AddStudent(gradStudentAlice);

        Console.WriteLine(gradStudentAlice.Name);
        Console.WriteLine("Student in the Computer Science Department");

        foreach(var student  in comSciDop.GetStudents())
        {
            Console.WriteLine(student.Name);
        }
    
    }
}
