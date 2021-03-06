﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball_problem1
{
    class Program
    {
        static int mod = 1000000007;
        static private long kombinasi(int x, int y)
        {
            long hasil = 1;
            for (int i = 0; i < y; i++)
            {
                hasil = hasil * (x - i) / (i + 1);
            }
            return hasil % mod;
        }
        static long pangkat(long x, long y)
        {
            if (y == 0)
            {
                return 1;
            }
            if (y == 1)
            {
                return x;
            }
            if (x == 0)
            {
                return 0;
            }
            long setengah = pangkat(x, y / 2);
            if (y % 2 == 0)
            {
                return (setengah * setengah) % mod;
            }
            else
            {
                return (((setengah * setengah) % mod) * x) % mod;
            }
        }
        static long jawab(int a, int b)
        {
            int tempSwap = 0;
            if (a < b)
            {
                tempSwap = a;
                a = b;
                b = tempSwap;
            }
            if (a < 25)
            {
                return 0;
            }
            if (a == 25)
            {
                if (b >= 24)
                {
                    return 0;
                }
                else
                {
                    return kombinasi(a + b - 1, b);
                }
            }
            if (a - b != 2)
            {
                return 0;
            }
            else
            {
                return kombinasi(48, 24) * pangkat(2, a - 26) % mod;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hasil = ");
            Console.WriteLine(jawab(a, b));
            Console.ReadKey();
        }
    }
}
