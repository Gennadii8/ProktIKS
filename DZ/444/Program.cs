using System;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            UserFactory teacher_user = new TeacherFactory();
            Client c1 = new Client(teacher_user);

            Console.WriteLine("User: {0}    Allowed {1}", c1.TypeUsr(), c1.ToString());

            UserFactory student_user = StudentFactory.getStudentFactory();
            Client c2 = new Client(student_user);
            Console.WriteLine("User: {0}    Allowed {1}", c2.TypeUsr(), c2.ToString());
            
        }
    }
}
