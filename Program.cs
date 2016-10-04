using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a, b;
            int l;
            char s = 'x';
            bool f = false;
            char[,] array;
            array = new char[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    array[i, j] = '-';

            for (int p = 0; p < 9; p++)
            {
                do
                {
                    f = false;
                    x = int.Parse(Console.ReadLine());
                    a = (x - 1) / 3;
                    b = (x - 1) % 3;
                    if (array[a, b] != '-')
                    {
                        Console.WriteLine("ERROR");
                        f = true;
                    }
                } while (f);
                array[a, b] = s;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        Console.Write(array[i, j]);
                    Console.WriteLine();
                }

                for (int k = 0; k < 3; k++)
                {
                    l = 0;
                    while (((l < 2) && (array[k,l]!='-')) && (array[k, l] == array[k, l+1]))
                        l++;
                    if (l == 2)
                        goto Win;
                }
                
                for (int k = 0; k < 3; k++)
                {
                    l = 0;
                    while (((l < 2) && (array[l, k] != '-')) && (array[l, k] == array[l + 1, k]))
                        l++;
                    if (l == 2)
                        goto Win;
                }

                l = 0;
                while (((l < 2) && (array[l, l] != '-')) && (array[l, l] == array[l + 1, l + 1]))
                    l++;
                if (l == 2)
                    goto Win;

                l = 0;
                while (((l < 2) && (array[l, 2 - l] != '-')) && (array[l, 2 - l] == array[l + 1, 1 - l]))
                    l++;
                if (l == 2)
                    goto Win;

                if (s == 'x')
                    s = 'o';
                else
                    s = 'x';
            }
            Console.WriteLine("(:)");
            return;
        Win:
            if (s == 'x')
                Console.WriteLine("1'st - WIN");
            else
                Console.WriteLine("2'nd - WIN");
        }
    }
}