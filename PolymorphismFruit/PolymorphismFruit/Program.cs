using System;
// the idea of the assigment is to:
// give derived classes the ablity to share functionality with base classes
// the derived classes keep there unique behavior through using keywords as: virtual & override
namespace PolymorphismFruit
{   // using Polymorphism:
    //The word polymorphism means having many forms,
 //Real life example of polymorphism:
 //A person at the same time can have different characteristic.
 //Like a man at the same time is a father, a husband, an employee.
    class Program
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit();
            f1.GetCost();
            Fruit f2 = new Apple(.5);
            f2.GetCost();
            Fruit f3 = new Banana(.25);
            f3.GetCost();
            Fruit f4 = new Orange(.6);
            f4.GetCost();
        }
    }
    class Fruit // base class
    {
        public double Cost { get; protected set; }
        public virtual void GetCost()// virtual lets derive classes override the methode " in this example GetCost "
        {
            Console.WriteLine("Getting cost of fruit...");
        }
    }
    class Apple : Fruit // derived class
    {
        public Apple(double c)
        {
            Cost = c;
        }
        public override void GetCost()
        {
            Console.WriteLine("Apples are ${0} a dozen", Cost * 12);
        }
    }
    class Banana : Fruit // derived class
    {
        public Banana(double c)
        {
            Cost = c;
        }
        public override void GetCost()
        {
            Console.WriteLine("banana's are ${0} a dozen", Cost * 12);
        }
    }
    class Orange : Fruit // derived class
    {
        public Orange(double c)
        {
            Cost = c;
        }
        public override void GetCost()
        {
            Console.WriteLine("oranges are ${0} a dozen", Cost * 12);
        }
    }
}
