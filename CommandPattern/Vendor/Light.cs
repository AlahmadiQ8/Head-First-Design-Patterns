using System;
using System.Runtime.CompilerServices;

namespace CommandPattern.Vendor
{
    public class Light : Device
    {
        public void On()
        {
            LogAction(GetCaller());
        }

        public void Off()
        {
            LogAction(GetCaller());
        }

        public Light(string name) : base(name)
        {
        }
    }
}