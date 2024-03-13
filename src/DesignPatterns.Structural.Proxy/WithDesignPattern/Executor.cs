using DesignPatterns.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.WithDesignPattern
{
    public class Executor : ExecutorWithExample
    {
        public override string GetName() => "Proxy";

        public override void Execute()
        {
            var driver = new HumanDriver();
            var autopilot = new AutoPilotDriver(driver);

            var car = new Car(autopilot);
            car.StartCruise();
        }
    }
}
