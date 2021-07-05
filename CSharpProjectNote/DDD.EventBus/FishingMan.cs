using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.EventBus
{
    /// <summary>
    /// 垂钓者(观察者)
    /// </summary>
    public class FishingMan
    {
        public string Name { get; set; }
        public int FishCount { get; set; }
        public FishingMan(string name)
        {
            Name = name;
        }
        public FishingRod FishingRod { get; set; }

        public void Fishing()
        {
            this.FishingRod.ThrowHook(this);
        }

        public void Update(FishType type)
        {
            FishCount++;
            Console.WriteLine($"{Name}:钓到一条{type},已经钓到{FishCount}条鱼！");
        }
    }
}
