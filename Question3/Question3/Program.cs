using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 5;
            int value2 = 10;
            int result = 0;
            AddNum(value1, value2, ref result);
        }

        static void AddNum(int num1, int num2, ref int result)
        {
            result = num1 + num2;
        }
    }
}
