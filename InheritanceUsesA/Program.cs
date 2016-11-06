using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUsesA
{
    //USES-A Class; static is used lots
    static class copyright
    {//one copy is in memory
        static public void print()
        {
            Console.WriteLine("copyright SAIT");
        }
    }
    class engine
    {
        public int power;
        public int cylinders;
    }
    class body
    {
        public int door;
        public string color;
    }
    class car
    {
        public engine engine = new engine(); //HAS-A inheritance
        public body body = new body(); //HAS-A (make sure variables are descriptive)
        public double price;
    }
    class worker
    {
        public string name;
        public double salary;
        public void print()
        {
            copyright.print(); //no need to use NEW or inherit in class
            Console.WriteLine(name + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.engine.cylinders = 6;
            car c2 = new car();
            c2.price = c.price;
            //Copy must get each composite object; i.e., each variable in each class
            //cannot just ust class names
            c2.engine.cylinders = c.engine.cylinders; //OK
            c2.engine.power = c.engine.power;
            c2.body = c.body;//NOT OK
            c.engine.cylinders = 4;
            Console.WriteLine(c2.engine.cylinders);

            copyright.print();
            Console.ReadLine();
        }
    }
}
