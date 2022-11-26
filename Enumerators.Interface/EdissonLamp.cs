using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators.Interface
{
    internal class EdissonLamp : ILight
    {
        public float Brightness { get; set ; }
        public bool IsLightOnOFF { get; set; }
        public Lamps type { get ; set ; }

        public void SetBrightness(float brightness)
        {
           this.Brightness = brightness;
            
        }

        public void SetIsLightOnOFF(bool isLightOnOff)
        {
           this.IsLightOnOFF = isLightOnOff;
           
        }

        public void StatusChecker()
        {
            Console.WriteLine($"The Light is {IsLightOnOFF}, Brightness is {Brightness}, The Lamp is {type}");
        }

    }
}
