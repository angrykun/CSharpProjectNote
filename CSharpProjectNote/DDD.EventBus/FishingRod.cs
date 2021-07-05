using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.EventBus
{
    /// <summary>
    /// 鱼竿(被观察者)
    /// </summary>
    public class FishingRod
    {
        public delegate void FishingHandler(FishType type);//声明委托

        public event FishingHandler FishingEvent;//生命事件

        public void ThrowHook(FishingMan man)
        {
            Console.WriteLine("开始下钩");

            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType)new Random().Next(0, 5);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                if (FishingEvent != null)
                {
                    FishingEvent(type);
                }
            }
            else
            {
                Console.WriteLine("鱼饵吃完啦，没有鱼");
            }
        }
    }
}
