using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class UserFactory
    {
        public abstract AbstractUser CreateUser();
        public abstract AbstractType CreateType();
    }
}
