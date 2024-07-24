using System.Runtime.CompilerServices;

namespace AnimalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Animal();
            t1.Name = "Test";
            t1.Age = 1;
            Console.WriteLine(t1);

            var t2 = new Animal { Name="Test2" };
            Console.WriteLine(t2);
            t2.Move();

            var t3 = new Mammal();
            Console.WriteLine(t3);
            t3.Move();

            var t4 = new Bird();
            Console.WriteLine(t4);
            t4.Move();


        }
    }
}
