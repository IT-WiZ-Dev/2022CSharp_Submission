using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("割られる数を入力してください:");
                    string dividendInput = Console.ReadLine();

                    Console.WriteLine("割る数を入力してください:");
                    string divisorInput = Console.ReadLine();

                    // 入力値の検証
                    if (!IsValidInput(dividendInput) || !IsValidInput(divisorInput))
                    {
                        Console.WriteLine("入力文字列の形式が正しくありません");
                        break;
                    }

                    int dividend = int.Parse(dividendInput);
                    int divisor = int.Parse(divisorInput);

                   
                    if (divisor == 0)
                    {
                        Console.WriteLine("０では割れません、再入力してください");
                        continue;
                    }

                    
                    int quotient = dividend / divisor;

                 
                    if (quotient == 0)
                    {
                        Console.WriteLine("商: " + quotient);
                        ProcessContinue();
                        continue;
                    }

                    Console.WriteLine("商の計算中...");

                    string quotientStr = quotient.ToString();
                    int quotientDigits = quotientStr.Length;

                    
                    int remainder = dividend % divisor; 
                    int decimalPlaces = 0;

                    while (remainder != 0 && decimalPlaces <= 50)
                    {
                        
                        remainder *= 10;
                        int digit = remainder / divisor;

                     
                        quotientStr += digit.ToString();

                        remainder %= divisor;
                        decimalPlaces++;
                    }

                    
                    Console.WriteLine("商: " + quotientStr);

                    ProcessContinue();
                }
            }
        }

        private static void ProcessContinue()
        {
            Console.WriteLine("処理を続けますか？（y/n）");
            string input = Console.ReadLine();

            if (input.ToLower() != "y")
            {
                Environment.Exit(0); // アプリケーションを終了


            }
        }

        private static bool IsValidInput(string input)
        {
            int value;
            return int.TryParse(input, out value);
        }
    }

}


