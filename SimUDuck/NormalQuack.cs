using System;

namespace SimUDuck
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Normal Quack");
        }
    }
}