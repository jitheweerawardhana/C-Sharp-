using computerArch;

class Program
{
    static void Main(string[] args)
    {
        University university = new University("NSBM", "Homagama");
        Department comSciDep = new Department("Computer Science", "CS");
        Professor professor = new Professor("smith", "p123", "AI");
        Course aiCourse = new Course("AI", "AI123", 40);
        Student studentTom = new Student("TOM", "1234", ""); 

        university.AddDepartment(comSciDep);
        comSciDep.AddStudent(studentTom);
        comSciDep.AddProfessors(professor);
        comSciDep.AddCourse(aiCourse);
        aiCourse.SetProfessor(professor);
        aiCourse.EnrollStudent(studentTom);

        GraduateStudent gradStudentAlice = new GraduateStudent("Alice", "222", "CS", "ML");
        comSciDep.AddStudent(gradStudentAlice);
        
        Console.WriteLine(gradStudentAlice.Name);
        Console.WriteLine("Students in the computer science department");
        foreach(var student in comSciDep.GetStudents())
        {
            Console.WriteLine(student.Name);
        }
    }
}