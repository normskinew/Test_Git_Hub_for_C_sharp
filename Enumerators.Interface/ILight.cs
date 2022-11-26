using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators.Interface
{
    internal interface ILight
    {
        float Brightness { get; set; }
        bool IsLightOnOFF { get; set; }
        Lamps type { get; set; }
        void SetBrightness(float brightness);
        void SetIsLightOnOFF(bool isLightOnOff);
        void StatusChecker();
    }
}
