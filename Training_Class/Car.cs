using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training_Class
{//Тренування створення об"єктів класу, створення конструктору класу, статична змінна чи ф-я, встановлення аксесора get/set для змінної, 
    internal class Car
    {
        protected float weight = 0;
        protected string color = string.Empty;
        protected string model = string.Empty;
        protected float speed = 0f;
        protected string name = string.Empty;
        
        public static int count = 0;
        public float Speed
        {
            set{ if (value < 0)
                speed = 0;
                else speed = value;
            }
            get {
                
                return speed; }
        }
        
        
        public Car(float weight, string color, string model, float speed)
        {
            this.weight = weight;
            this.color = color;
            this.model = model;
            Speed = speed;
            
            count++;
        }
        public Car()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Started 0 paremeters constructor CAR");
            count++;
        }

        public static void CountFunc()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Called {count} constructors");
        }
        public virtual void PrintAll()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Car's model: {model}, color: {color}, weight: {weight}, speed: {Speed}, owner: {name}");
        }
        public class Engine
        {
            private int[] rotateSpeed = { 100, 150, 200 };
            private bool startEngine = false;
            public void IsStarted(bool startEngine)
            {
                this.startEngine = startEngine;
                Console.WriteLine(startEngine);   
            }
            public void GetRotateSpeed()
            {   Console.ForegroundColor = ConsoleColor.Magenta;
               for(int i = 0; i < rotateSpeed.Length; i++)
                {
                    Console.WriteLine($"Speed is {i}");
                }
            }
        }

    }
}
