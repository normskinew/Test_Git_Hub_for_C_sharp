using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Training_Class
{
    internal class Owners : Car
    {

        public Owners(string name, float weight, string color, string model, float speed) : base(weight, color, model, speed)
        {
            this.name = name;
        }
        public Owners()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Started 0 paremeters constructor Owners");
        }
        public override void PrintAll()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Car's model: {model}, color: {color}, weight: {weight}, speed: {Speed}, owner: {name}");
        }
    }
}
