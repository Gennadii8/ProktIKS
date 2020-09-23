using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class StudentUser: AbstractUser
    {
        public StudentUser(string name)
        {
            Name = name;
        }

        public override string Type(AbstractType type)
        {
            string s = type.type;
            return s;
        }

        public override string ToString()
        {
            return "Permission - " + Name;
        }
    }
}
