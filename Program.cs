using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        class cars 
        {
              // عبدالرحمن  محمد عبدالرحمن منصور 
              //  سكشن 12

          public int model;
          public string color;
          public string type;
          public int Acceleration;
          public int NumofPassengers;
          public int Numofcylinders;
          public int EngineCapacity;
          public int Topspeed;


            public cars()
            {
                model =2000;
            }
            public cars(int model) 
            { 
                this.model = model;
            }
            public cars(string color)
            {
                this.color = color;
            }
            public cars(string type,int Numofcylinders)
            {
                this.type = type;
                this.Numofcylinders = Numofcylinders;
            }
            public cars(int model,int topspeed)
            {
                this.Topspeed = topspeed;
            }



            public void move() 
            {
                Console.WriteLine("car is moving");
            }
            public  void speed()
            {
              Console.WriteLine("speed up");
            }
            public void break1()
            {
                Console.WriteLine();
            }
            public void changespeed()
            {
                Console.WriteLine("speed is changing");
            }
            public void changeAcceleration()
            {
                Console.WriteLine("Acceleration is changing");
            }
            public void Changingdirection()
            {
                Console.WriteLine(" direction is changing");
            }


        }
        

        static void Main(string[] args)
        {
            cars car1 = new cars();
            car1.model = 2016;
            car1.type = "honda";
            car1.color = "black";
            car1.Acceleration = 60;
            car1.NumofPassengers = 4;
            car1.Numofcylinders = 6;
            car1.EngineCapacity = 2;
            car1.Topspeed = 200;

         
        }

    }

}
