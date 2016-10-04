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
            int u;
            u = int.Parse(Console.ReadLine());
            if (u < 3)
            {
                Console.WriteLine("ERROR. U must be more than 2.");
                return;
            }
            int x;
            int a, b;
            int l;
            char s = 'x';
            bool f = false;
            char[,] array;
            array = new char[u, u];

            for (int i = 0; i < u; i++)
                for (int j = 0; j < u; j++)
                    array[i, j] = '-';

            for (int p = 0; p < u*u; p++)
            {
                do
                {
                    f = false;
                    x = int.Parse(Console.ReadLine());
                    a = (x - 1) / u;
                    b = (x - 1) % u;
                    if (array[a, b] != '-')
                    {
                        Console.WriteLine("ERROR. TRY AGAIN.");
                        f = true;
                    }
                } while (f);

                array[a, b] = s;

                for (int i = 0; i < u; i++)
                {
                    for (int j = 0; j < u; j++)
                        Console.Write(array[i, j]);
                    Console.WriteLine();
                }

                for (int k = 0; k < u; k++)
                {
                    l = 0;
                    while (((l < (u-1)) && (array[k,l]!='-')) && (array[k, l] == array[k, l+1]))
                        l++;
                    if (l == (u-1))
                        goto Win;
                }
                
                for (int k = 0; k < u; k++)
                {
                    l = 0;
                    while (((l < (u-1)) && (array[l, k] != '-')) && (array[l, k] == array[l + 1, k]))
                        l++;
                    if (l == (u-1))
                        goto Win;
                }

                l = 0;
                while (((l < (u-1)) && (array[l, l] != '-')) && (array[l, l] == array[l + 1, l + 1]))
                    l++;
                if (l == (u-1))
                    goto Win;

                l = 0;
                while (((l < (u-1)) && (array[l, 2 - l] != '-')) && (array[l, 2 - l] == array[l + 1, 1 - l]))
                    l++;
                if (l == (u-1))
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