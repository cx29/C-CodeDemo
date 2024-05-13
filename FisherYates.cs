using System;
using System.Collections.Generic;

namespace utils
{
    /// <summary>
    /// 洗牌算法,随机取不重复的,会对集合的所有内容进行随机排列
    /// </summary>
    public class FisherYates<T>
    {
        public List<T> Fisher(List<T> origin,int needCount)
        {
            try
            {
                Random random = new Random();
                int num = origin.Count;
                while (num > 1)
                {
                    num--;
                    int tag = random.Next(num + 1);
                    //通过析构的方式来交换两个变量的值
                    (origin[tag], origin[num]) = (origin[num], origin[tag]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fisher has Error, the message is :{e.Message}");
            }

            return origin;
        }
    }
}
