using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AudiFactory : CarFactory
    {
        private static AudiFactory audiFactory = null;

        private AudiFactory() { }

        public static AudiFactory getAudiFactory()
        {
            if (audiFactory == null)
            {
                audiFactory = new AudiFactory();
            }
            return audiFactory;
        }
 
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Audi");
        }

        public override AbstractEngine CreateEngine()
        {
            return new AudiEng();
        }

        public override AbstractShape CreateShape()
        {
            return new AudiShape();
        }
    }
}
