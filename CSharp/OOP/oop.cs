using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
    
            
            Car a = new Car();
            a.Color = "red";
            a.MaxSpeed = 170;
            a.Start();
            Console.WriteLine("Car is running:" + a.MotorRunning);
            a.Accelerate();
            Console.WriteLine("Car has accelerated. The speed is now:"+ a.Speed);

            a.Brake();
            Console.WriteLine ("Car is slowing down" + a.Speed);

            a.Stop();
            Console.WriteLine("Car has stopped:" + a.Speed);
            
            Car b = new Car();
            b.MotorRunning = false; 
            b.Color = "grey";
            b.Start();
            b.MaxSpeed = 200;

        }
    }
}
