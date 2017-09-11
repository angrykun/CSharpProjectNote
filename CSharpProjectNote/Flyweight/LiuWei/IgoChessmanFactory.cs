using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.LiuWei
{
    /// <summary>
    /// 享元工厂类
    /// </summary>
    public class IgoChessmanFactory
    {
        private static IgoChessmanFactory instance = new IgoChessmanFactory();
        private  Hashtable hashTable;

        public IgoChessmanFactory()
        {
            hashTable = new Hashtable();
            IgoChessman blackIgoChessman = new BlackIgoChessman();
            hashTable.Add("b", blackIgoChessman);

            IgoChessman whiteIgoChessman = new WhiteIgoChessman();
            hashTable.Add("w", whiteIgoChessman);
        }
        public static IgoChessmanFactory GetInstance()
        {
            return instance;
        }

        public  IgoChessman GetIgoChessman(string key)
        {
            if (hashTable.ContainsKey(key))
            {
                return hashTable[key] as IgoChessman;
            }
            return null;
        }
    }
}
