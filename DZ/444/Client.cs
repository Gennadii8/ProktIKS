using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private AbstractUser abstractUser;
        private AbstractType abstracttype;

        public Client(UserFactory user_factory)
        {
            abstractUser = user_factory.CreateUser();
            abstracttype = user_factory.CreateType();
        }

        public string TypeUsr()
        {
            return abstracttype.type;
        }

        public override string ToString()
        {
            return abstractUser.ToString();
        }
    }
}
