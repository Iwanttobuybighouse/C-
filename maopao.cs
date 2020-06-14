using System;

namespace ConsoleApplication
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int[] str = new int[10];
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("请输入第{0}个数字", i + 1);
                str[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] str2 = MaoPao(str);
            for (int n = 0; n <= str2.Length; n++)
            {
                Console.WriteLine("第{1}个数：{0}",str2[n],n);
            }
            Console.ReadKey();
        }
        public static int[] MaoPao(int[] str)
        {
            int[] a = str;
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = a.Length - 1; j > i; j--)
                {
                    if (a[j]< a[j - 1])
                    {
                        int temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
                }
            }
            return a;

        }
    }
}