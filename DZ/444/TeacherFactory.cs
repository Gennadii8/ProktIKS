using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class TeacherFactory : UserFactory
    {
        public override AbstractUser CreateUser()
        {
            return new TeacherUser("Advanced");
        }

        public override AbstractType CreateType()
        {
            return new TeacherType();
        }
    }
}
