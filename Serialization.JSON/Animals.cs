using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.JSON
{
    [Serializable]
    public class Animals
    {
        public int age;
        public string name;
        public Animals(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Animals()
        {

        }
    }
}
