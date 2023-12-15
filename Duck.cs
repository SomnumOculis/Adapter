using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Утка крякает");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Утка летит");
        }
    }

}
