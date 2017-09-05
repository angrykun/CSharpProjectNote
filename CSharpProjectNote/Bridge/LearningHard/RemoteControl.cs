using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.LearningHard
{
    /// <summary>
    /// 抽奖概念中的遥控器，扮演抽象化角色
    /// </summary>
    public class RemoteControl
    {
        public TV Implementor { get; set; }
        /// <summary>
        /// 开机
        /// </summary>
        public virtual void On()
        {
            Implementor.On();
        }
        /// <summary>
        /// 关机
        /// </summary>
        public virtual void Off()
        {
            Implementor.Off();
        }
        /// <summary>
        /// 切换频道
        /// </summary>
        public virtual void SetChannel()
        {
            Implementor.tuneChannel();
        }

    }
}
