using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace CommandPattern
{
    public abstract class Device
    {
        private readonly string _name;

        protected Device(string name)
        {
            _name = name;
        }
        
        protected static string GetCaller([CallerMemberName]
            string caller = null)
        {
            return caller;
        }

        protected void LogAction(string action)
        {
            Console.WriteLine($"Vendor {this.GetType().Name}-{_name} executed action {action}");
        }
    }
}