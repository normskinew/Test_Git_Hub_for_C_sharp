using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteaProjectCivilization.Events;

namespace IteaProjectCivilization
{
    delegate void DelegatForEvents(object sender, CustomArgs e);
    
    internal class Events
    {
       
        public event DelegatForEvents? OnDisease,OnStarvation,OnEnginnering;
        public void OnDiseaseFunc()
        {
            OnDisease?.Invoke(this, new CustomArgs(10));
            
        }
        public void OnStarvationFunc()
        {
            OnStarvation?.Invoke(this, new CustomArgs(50));

        }
        public void OnEnginneringFunc()
        {
            OnEnginnering?.Invoke(this, new CustomArgs(10));

        }

        public  class CustomArgs : EventArgs
        {
            public int _percentage;
            
            public CustomArgs(int percentageOfDiseas)
            {
                _percentage = percentageOfDiseas;
            }
        }

    }
}
