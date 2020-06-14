using System;

namespace ConsoleApplication
{
    class insertsort
    {
        static void Main(string[] args)
        {
            int[] str = new int[7];
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("请输入第{0}个数字", i + 1);
                str[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] str2 =Insert(str);
            for (int n = 0; n < str2.Length; n++)
            {
                Console.WriteLine("第{1}个数：{0}",str2[n],n);
            }
            Console.ReadKey();
        }
        public static int[] Insert(int[] str)
        {
            int[] a = str;
            for(int i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                int j;
                for(j = i-1; j>=0; j--)
                {
                    if (temp > a[j])
                        break;
                    a[j + 1] = a[j];
                }
                a[j + 1] = temp;
            }
            return a;

        }
    }
}