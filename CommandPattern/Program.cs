using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using CommandPattern.Commands;
using CommandPattern.Vendor;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var livingRoomLight = new Light("LivingRoom");
            var kitchenLight = new Light("Kitchen");
            var garage = new GarageDoor("Main");
            var fan = new CeilingFan("LivingRoom");
            
            var remote = new SimpleRemoteControl("My Remote");
            
            remote.SetCommand(0, livingRoomLight.On, livingRoomLight.Off);
            remote.SetCommand(1, kitchenLight.On, kitchenLight.Off);
            remote.SetCommand(2, garage.Up, garage.Down);
            remote.SetCommand(3, fan.High, fan.Off);

            Console.WriteLine(remote);

            var light1 = new Light("light1");
            var light2 = new Light("light2");
            var garage1 = new GarageDoor("garage1");
            var fan1 = new CeilingFan("fan1");
            Action command = () =>
            {
                light1.On();
                light2.On();
                garage1.Up();
                fan1.High();
            };
            
            remote.SetCommand(4, command, () => { });
            remote.OnButtonWasPressed(4);
        }
    }
}