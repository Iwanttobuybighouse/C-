using System;

namespace ConsoleApplication
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            //打印出斐波那契数列的前50项
            double[] feibo = new double[100];
            feibo[0] = 1;
            feibo[1] = 1;
            for(int i = 2; i < 100; i++)
            {
                feibo[i] = feibo[i - 1] + feibo[i - 2];
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("斐波那契第{1}个数：{0}", feibo[i],i+1);
            }
        }
    }
}