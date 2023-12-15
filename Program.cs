using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck Duck = new Duck();
            Duck.Quack();
            Duck.Fly();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Quack();
            rubberDuck.Fly();

            Pheasant pheasant = new Pheasant();
            Duck Adapter = new Adapter(pheasant);
            Adapter.Quack();
            Adapter.Fly();
            Console.ReadLine();
        }
    }
}
