using System;

namespace Olympic_Winter_2020
{
    public class Program
    {
		public static int Pow(int a, int n)   // повдига a на степен n
		{
			int res = 1;
			for (int i = 0; i < n; ++i)
				res *= a;
			return res;
		}
		public static int Replace(int number, int d1, int d2)
		{
			int position = 0;
			int result = 0;
			while (number != 0)
			{
				int digit = number % 10;
				number /= 10;
				if (digit == d1) digit = d2;
				result += digit * Pow(10, position++);
			}
			return result;
		}
		public static string Calculate(string input)
		{
			string[] tokens = input.Split();
			int A = int.Parse(tokens[0]);
			int B = int.Parse(tokens[1]);
			int A_min = Replace(A, 8, 3);
			int B_min = Replace(B, 8, 3);
			int min_sum = A_min + B_min;
			int A_max = Replace(A, 3, 8);
			int B_max = Replace(B, 3, 8);
			int max_sum = A_max + B_max;
			return $"{min_sum} {max_sum}";
		}
		static void Main(string[] args)
        {
			Console.Write(">> ");
			var result = Calculate(Console.ReadLine());
			Console.WriteLine(result);
		}
    }
}
