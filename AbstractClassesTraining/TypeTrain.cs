using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesTraining
{
    public class TypeTrain<T1,T2>
    {
        public T1? field;
        public T2? field_2;
        public TypeTrain(T1? field, T2? field_2)
        {
            this.field = field;
            this.field_2 = field_2;
            Console.WriteLine($"field 1 : {field}, field 2 : {field_2}");
        }
    }
}
