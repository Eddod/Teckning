using System;

namespace Teckning
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning Cirkel = new Cirkel();
            Console.WriteLine("Arean på cirkeln  : {0}",Cirkel.Area());

            Triangle Test = new Triangle();
            Console.WriteLine("Arean på triangeln  : {0}",Test.Area());

            Rectangle R1 = new Rectangle();
            Console.WriteLine("Arean på rektangeln  : {0}", R1.Area()); 


        }
    }
}
