using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Comparetwoobjectreflection
{
    class Variance
    {
        public string ChangedProperty { get; set; }
        public object AfterValue { get; set; }
        public object BeforeValue { get; set; }
    }

    class SomeCustomClass
    {
        public string x = "10";
        public int y = 20;
        public int z = 30;
    }
    static class Extensions
    {
        public static List<Variance> DetailedCompare<T>(this T val1, T val2)
        {
            List<Variance> variances = new List<Variance>();
            FieldInfo[] fi = val1.GetType().GetFields();
            foreach (FieldInfo f in fi)
            {
                Variance v = new Variance();
                v.ChangedProperty = f.Name;
                v.AfterValue = f.GetValue(val1);
                v.BeforeValue = f.GetValue(val2);
                if (!Equals(v.AfterValue, v.BeforeValue))
                {
                    variances.Add(v);
                }
            }
            return variances;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeCustomClass a = new SomeCustomClass();
            SomeCustomClass b = new SomeCustomClass();
            //a.x = 100;
            //a.z = 50;
            a.y = 100;
            List<Variance> rt = a.DetailedCompare(b);
            foreach (var item in rt)
            {
                Console.WriteLine($"Changed Property {item.ChangedProperty}");
                Console.WriteLine($"Before Value {item.BeforeValue}");
                Console.WriteLine($"After Value {item.AfterValue}");
            }
            Console.ReadKey();
        }
    }
}
