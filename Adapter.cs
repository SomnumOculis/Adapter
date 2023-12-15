using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : Duck
    {
        private Pheasant _pheasant;

        public Adapter(Pheasant pheasant)
        {
            _pheasant = pheasant;
        }

        public override void Quack()
        {
            _pheasant.Shout();
        }

        public override void Fly()
        {
            _pheasant.Fly();
        }
    }
}
