using System;

namespace code_test
{
    class Program
    {
        

            public static void Main(string[] args)
            {

                string a = "abcdefghijklmnopqrst";
                for (int i = 0; i < a.Length; i = i + 2)
                {

                    Console.WriteLine(a[i]);

                }
            }
        }
    }

