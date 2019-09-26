using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car
    {

        //fields
        private int speed=0;

        //properties

        
        public string Color {get; set; }
        public int MotorType {get; set; }
        public int DoorCount {get; set; }
        public int MaxSpeed {get; set; }

        public int Speed 
        {
            get {return speed;}
            set 
            {
                if (value > MaxSpeed) 
                {
                    Console.WriteLine ("Too fast!");
                }
                else
                {
                    speed = value;
                }

            }

        }
        public bool MotorRunning { get; set; }


        //methods
        public void Start()
        {
            MotorRunning = true;
        }
        public void Stop()
        {
            Speed = 0;
            MotorRunning=false;
        }
        public void Accelerate()
        {
            if (MotorRunning) {Speed = Speed+20;}

            //if  (Speed>MaxSpeed)
            //{
             //   Speed = MaxSpeed;
           // }

            
        }
        public void Brake()
        {
            Speed -= 10;
        }

    
    }
}
