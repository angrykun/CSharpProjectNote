using System;
using System.Threading;

namespace DDD.EventBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fishingRod = new FishingRod();

            var fishingMan = new FishingMan("张三");

            //分配鱼竿
            fishingMan.FishingRod = fishingRod;
            //注册观察者
            fishingRod.FishingEvent += fishingMan.Update;

            //钓鱼

            while (fishingMan.FishCount < 5)
            {
                fishingMan.Fishing();
                Console.WriteLine("--------------------------");
                Thread.Sleep(5000);
            }







        }
    }
}
