using System;

namespace study
{

    /// <summary>
    /// 2~50 사이 랜덤값 뽑아서 그게 홀수면 +1 짝수도 구구단 출력
    /// 뽑힌게 짝수면 -1해서 홀수도 구구단 출력
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int index = random.Next(2, 50);
            Console.WriteLine($"뽑힌숫자 :{index}");
            if (index % 2 != 0) //홀수
            {
                for (int j = 1; j <= 9; j++)
                {
                    int result = index * j;
                    Console.WriteLine($"{index} * {j} = {result}");
                }
                Console.WriteLine();

                for (int j = 1; j <= 9; j++)
                {
                    int result = (index + 1) * j;
                    Console.WriteLine($"{index + 1} * {j} = {result}");
                }
                Console.WriteLine();
            }
            else
            {
                for (int k = 1; k <= 9; k++)
                {
                    int result = index * k;
                    Console.WriteLine($"{index} * {k} = {result}");
                }
                Console.WriteLine();

                for (int k = 1; k <= 9; k++)
                {
                    int result = (index - 1) * k;
                    Console.WriteLine($"{index - 1} * {k} = {result}");
                }
                Console.WriteLine();
            }
        }
    }
}


