using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class TeacherUser : AbstractUser
    {
        public TeacherUser(string name)
        {
            Name = name;
        }

        public override string Type(AbstractType type)
        {
            string sh = type.type;
            return sh;
        }

        public override string ToString()
        {
            return "Permission - " + Name;
        }
    }
}
