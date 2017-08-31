using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.LiuWei
{
    /// <summary>
    /// 周报
    /// </summary>
    [Serializable]
    public class WeekLog
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public Attachment Attachment { get; set; }
        public object BinaryFomater { get; private set; }

        public WeekLog(string name, string date, string content, Attachment attchment)
        {
            Name = name;
            Date = date;
            Content = content;
            Attachment = attchment;
        }

        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public WeekLog Clone()
        {
            return MemberwiseClone() as WeekLog;
        }
        /// <summary>
        /// 深克隆
        /// </summary>
        /// <returns></returns>
        public WeekLog DeepClone()
        {
            object obj;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                obj = bf.Deserialize(ms);
                ms.Close();
            }
            return obj as WeekLog;
        }
    }
}
