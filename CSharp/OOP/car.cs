using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car
    {
        //properties
        public string Color {get; set; }
        public int MotorType {get; set; }
        public int DoorCount {get; set; }
        public int MaxSpeed {get; set; }

        public int Speed {get; set;}

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
            if (MotorRunning) {Speed += 10;}
            
        }
        public void Brake()
        {
            Speed -= 10;
        }

    
    }
}
