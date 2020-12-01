using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Utils2
    {
        public static double Ejercicio1a (double metros)
        {
            return metros / 1609;
        }

        public static string Ejercicio2c (int number1, int number2)
        {
            if (number1 > 0 && number2 > 0)
                return ("Los dos números son positivos");
            else if (number1 > 0 || number2 > 0)
                return ("Uno de los números es positivo");
            else
                return ("Ninguno de los números es positivo");
        }

        public static void Ejercicio3a (int number1, int number2, int number3)
        {
            if (number1 >= number2 && number1 >= number3)
                Console.WriteLine(number1);
            else if (number2 >= number1 && number2 >= number3)
                Console.WriteLine(number2);
            else
                Console.WriteLine(number3);
        }

        public static int ReadOption (string message)
        {
            try
            {
                Console.WriteLine(message);
                string option = Console.ReadLine();
                int result = Convert.ToInt32(option);
                return result;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static void Ejercicio4b ()
        {
            
            int option = ReadOption("Inserta un número del 1 al 3");

            switch(option)
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

        public static int ReadInteger(string message)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(message);
                    string line = Console.ReadLine();
                    int result = Convert.ToInt32(line);
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine("inserta un número");
                }
            }
        }
        public static void Ejercicio6a ()
        {
            while (true)
            {
                int Base = ReadInteger("Inserta la base del exponente 2");

                if (Base != 0)
                    Console.WriteLine("Resultado " + Base * Base);
                else
                    break;
            }
        }

        public static void Ejercicio7a ()
        {
            int number = ReadInteger("Inserta un número");
            int result = 0;

            for (int i = 1; i <= number; i++)
            {

                if ((i % 5) == 0)
                {
                    result = result + i;

                }
            }
            Console.WriteLine("resultado: " + result);
        }

        public static void Ejercicio10 (int alto, int largo)
        {
            int alto2 = alto / 2;

            for (int f = 1; f <= alto2 + 1; f++)
            {
                for (int c = 1; c <= f; c++)
                    Console.Write("+");
                for (int f3 = 1; f3 < largo - alto2 - f; f3++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int f2 = alto - alto2; f2 < alto; f2++)
            {
                for (int c2 = 1; c2 <= alto - f2; c2++)
                    Console.Write("+");
                for (int f4 = 1; f4 < largo - alto; f4++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }


        }
    }
}
