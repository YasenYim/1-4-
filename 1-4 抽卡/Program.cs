using System;

namespace _1_4_抽卡
{
    class Program
    {
        static void Main(string[] args)
        {
            // 练习1.2
            /*抽卡游戏，40%概率获得黄忠，30%概率获得张飞，20%概率获得赵云，10%概率获得关羽。
             * 提示Random random = new Random();
             * int r = Random.Next(0, 100);
             
             * 分析 0-99的闭区间 
             * 00-09 关羽
             * 10-29 赵云
             * 30-59 张飞
             * 60-99 黄忠
            */

            Random random = new Random();
            int r = random.Next(0, 100);        // r的范围是0-99的闭区间

            string name = " ";

            if (r < 10)
            { name = "关羽"; }

            //else if (r >= 10 && r < 30)
            else if (r < 30) // 从程序运行的角度必然运行到这一步
            { name = "赵云"; }

            //else if (r >= 30 && r < 60)
            else if (r < 60) // 同理
            { name = "张飞"; }

            else
            { name = "黄忠"; }

            Console.WriteLine($"r={r}");
            Console.WriteLine($"抽到卡：{name}");

            Console.ReadKey();


            // 如果一个条件符合所有的区间，那么就不用else if了

            /* Random random = new Random();
             * int r = random.Next(0,100);
             * string name = " ";
             * 
             * r = 5;
             * 
             * if (r < 10)
             * {
             *      name = "关羽";
             *      Console.WriteLine($"抽到卡：{name}");
             * }
             * 
             * if (r >= 10 && r < 30)
             * {
             *      name = "赵云";
             *      Console.WriteLine($"抽到卡：{name}");
             * }
             * 
             * if (r >= 30 && r < 60)
             * {
             *      name = "张飞";
             *      Console.WriteLine($"抽到卡: {name}");
             * }
             * 
             * if (r >= 60 && r < 100)
             * {
             *      name = "黄忠";
             *      Console.WriteLine($"抽到卡: {name}");
             * }
             * 
             * Console.ReadKey();
             */


        }
    }
}
