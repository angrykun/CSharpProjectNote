using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LearningHard
{
    public class FlyweightFactory
    {
        public IDictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
            flyweights.Add("B", new ConcreteFlyweight("B"));
            flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            Flyweight flightweight = null;
            if (flyweights.ContainsKey(key))
            {
                flightweight = flyweights[key];
            }

            if (flightweight == null)
            {
                Console.WriteLine("驻留池中不存在字符串：" + key);
                flightweight = new ConcreteFlyweight(key);
            }
            return flightweight;
        }
    }
}
