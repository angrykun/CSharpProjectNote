using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.EventBus
{
    public interface IEventData
    {
        DateTime DateNow { get; set; }
    }
}
