using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Utils
    {
        public static string Ejer2C (int x, int y)
        {
            if (0 < x && 0 < y)
                return "los dos números son positivos";
            else if (0 > x && 0 > y)
                return "los dos números son negativos";
            return "uno de los números es positivo";
        }

        public static void Ejer3A (int a, int b, int c)
        {
            if (b < a && c < a)
                Console.WriteLine(a);
            else if (a < b && c < b)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
        }

        public static void Ejer3B (int a, int b, int c)
        {
            if (a > b && a > c)
                if (b > c)
                    Console.WriteLine(b);
                else
                    Console.WriteLine(c);
            else if (b > a && b > c)
                if (a > c)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(c);
            else
                Console.WriteLine(b);
        }

        public static void Ejer4A()
        {
            while (true)
            {
                Console.WriteLine("Elige un número del 1 al 5");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("UNO");
                        break;

                    case 2:
                        Console.WriteLine("DOS");
                        break;

                    case 3:
                        Console.WriteLine("TRES");
                        break;

                    case 4:
                        Console.WriteLine("CUATRO");
                        break;

                    case 5:
                        Console.WriteLine("CINCO");
                        break;

                    default:
                        Console.WriteLine("Error. Tiene que ser un número del 1 al 5");
                        break;
                }
            }
        }

        public static void Ejer4B()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Error Grave");
                    break;
                case 2:
                    Console.WriteLine("Error Medio");
                    break;
                case 3:
                    Console.WriteLine("Error Leve");
                    break;
                default:
                    Console.WriteLine("Error Desconocido");
                    break;
            }
        }

        public static void Ejer6A()
        {
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n != 0)
                    Console.WriteLine(n * n);
                else
                    break;
            }
        }

        public static void Ejer6B()
        {
            int result = 0;

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (0 < n)
                {
                    Console.WriteLine(n + result);
                    result = n + result;
                }
                else
                    break;
            }
        }

        public static void Ejer7A()
        {
            Console.Write("Pon un número positivo; ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                    result = result + i;
            }
            Console.WriteLine(result);
        }

        public static void Ejer7B()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int result2 = 0;

            for (int i = 1; i < x || i < y; i++)
            {
                result = x % i;
                result2 = y % i;

                if ( result == result2)
                    Console.WriteLine(i);
            }
        }

        //-5
        //-2
        //1
        //4
        //7
        public static void Ejer8()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i - 3; j < i + 10; j += 3)
                {
                    if (i == j)
                        break;
                    else if (j == 3)
                        continue;
                    System.Console.WriteLine(1 + i + j * 2);
                }
            }
        }

        public static int ReadInteger (string message)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    string line = Console.ReadLine();
                    int number = Convert.ToInt32(line);
                    return number;
                }
                catch(Exception e)
                {
                    Console.WriteLine("error");
                }
            }
        }


    }
}
