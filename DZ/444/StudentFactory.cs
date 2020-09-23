using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class StudentFactory : UserFactory
    {
        private static StudentFactory studentFactory = null;

        private StudentFactory() { }

        public static StudentFactory getStudentFactory()
        {
            if (studentFactory == null)
            {
                studentFactory = new StudentFactory();
            }
            return studentFactory;
        }
 
        public override AbstractUser CreateUser()
        {
            return new StudentUser("Base");
        }

        public override AbstractType CreateType()
        {
            return new StudentType();
        }
    }
}
