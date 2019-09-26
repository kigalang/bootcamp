using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
    
            
            Car a = new Car();
            a.Color = "red";
            a.MaxSpeed = 200;
            a.Start();
            Console.WriteLine("Car is running:" + a.MotorRunning);
            a.Accelerate();
            Console.WriteLine("Car has accelerated. The speed is now: "+ a.Speed);
            a.Brake();
            Console.WriteLine ("Car is slowing down: " + a.Speed);
            //Console.WriteLine("speed: " + a.Speed);
            a.Stop();
            Console.WriteLine("Car has stopped: The speed is now:" + a.Speed);
            
        
            Car b = new Car();
            b.Color = "grey";
            b.MaxSpeed = 250;    
            b.Start();
            b.Accelerate();
            b.Accelerate();
            Console.WriteLine("Car B's speed: " + b.Speed);


    

            BigTruck TruckA = new BigTruck();
            TruckA.MaxSpeed = 80;
            TruckA.Color = "white";
            TruckA.Capacity = 40;
            TruckA.Speed = 0;
            TruckA.Start();
            PrintColor(TruckA); 
        
        }

        static void PrintColor (Car varA)
        {
            Console.WriteLine (varA.Color);
        }
    }
}
