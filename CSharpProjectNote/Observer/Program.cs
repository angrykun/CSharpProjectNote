using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.LearningHard;
using Observer.LiuWei;

namespace Observer
{
    /**
     * 观察者模式：定义了一种一对多的依赖关系，让多个观察者对象同时监听一个主题对象，
     * 这个主题对象在状态发生变化时，会通知所有观察者，是他们能够自动更新自己的行为。
     *
     * 使用委托可以代替抽象观察者类的定义 。
     * **/

    internal class Program
    {
        private static void Main(string[] args)
        {
            MethodOne();

            MethodTwo();
        }

        private static void MethodOne()
        {
            //实例化订阅类和订阅者类
            Tengxun tengxun = new TengxunGame("TengXun Game", "Has a new Game Publish ...");
            tengxun.AddObserver(new Subscriber("Learning Hard"));
            tengxun.AddObserver(new Subscriber("Tom"));
            tengxun.Update();

            Console.ReadKey();
        }

        private static void MethodTwo()
        {
            AllyControlCenter acc = new ConcreteAllyControlCenter("金庸群侠");

            ObserverPlayer player1 = new Player();
            player1.Name = "杨过";
            acc.Join(player1);

            ObserverPlayer player2 = new Player();
            player2.Name = "令狐冲";
            acc.Join(player2);

            ObserverPlayer player3 = new Player();
            player3.Name = "张无忌";
            acc.Join(player3);

            ObserverPlayer player4 = new Player();
            player4.Name = "段誉";
            acc.Join(player4);

            //某成员遭受攻击
            player1.BeAttacked(acc);

            Console.ReadKey();
        }
    }
}