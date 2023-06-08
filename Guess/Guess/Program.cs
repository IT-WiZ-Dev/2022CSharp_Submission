// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

//Console.WriteLine("0から100の間の数値を当ててください。>");
//int result = int.Parse(Console.ReadLine());
int min = 0;
int max = 100;
int answer = 32;
int num = 0;
while(true){

    Console.WriteLine(min + "から" + max + "の間の数値を当ててください。 >");
    int result = int.Parse(Console.ReadLine());

    if(min>=result || max <= result)
    {
        Console.WriteLine("bye bye");
        continue;
    }
    if (answer > result) {
        Console.WriteLine("答えはもっと大きいです");
        num += 1;
        min = result+1;
    }
    else if (answer < result)
    {
        Console.WriteLine("答えはもっと小さいです");
        num += 1;
        max = result-1;
    }
    else if(answer == result)
    {
        num += 1;
        Console.WriteLine("おめでとう。" + num + "回目で当たりました。");
        break;
    }
    /*else
    {
        Console.WriteLine("入力が正しくない");
        continue;
    }
    */
}


