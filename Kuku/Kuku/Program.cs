using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuku
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("九九の表");

            int kotae = 0;

            for (int dan = 1; dan < 10; dan++)

            {

                for (int retu = 1; retu < 10; retu++)

                {

                    kotae = dan * retu;

                    Console.Write("{0,3}",kotae);

                }

                Console.WriteLine();

            }

            Console.ReadKey();

        }

    }

}
