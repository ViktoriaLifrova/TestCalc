using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это калькулятор");
            while (true)
            {
                Console.WriteLine("Выбирайте тип операции");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умноженение");
                Console.WriteLine("4 - деление");
               
                int typeOperation;

                if (!analizeInputData(Console.ReadLine(), out typeOperation))
                {
                    Console.WriteLine("Неверный тип данных");
                    continue;
                }

               

            

                switch (typeOperation)
                {
                    case 1:
                        int A = 0;
                        Console.WriteLine("Введите число A");
                        while (!analizeInputData(Console.ReadLine(), out A))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }


                        int B = 0;
                        Console.WriteLine("Введите число B");
                        while (!analizeInputData(Console.ReadLine(), out B))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        Console.WriteLine($"Результат сложения: {summary(A, B)}");
                        break;
                
                    case 2:
                        int D = 0;
                        Console.WriteLine("Введите число D");
                        while (!analizeInputData(Console.ReadLine(), out D))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        int C = 0;
                        Console.WriteLine("Введите число C");
                        while (!analizeInputData(Console.ReadLine(), out C))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        Console.WriteLine($"Результат вычитания: {sub(D, C)} ");
                        break;

                    case 3:
                       int X = 0;
                        Console.WriteLine("Введите число X");
                        while (!analizeInputData(Console.ReadLine(), out X))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        int Y = 0;
                        Console.WriteLine("Введите число Y");
                        while (!analizeInputData(Console.ReadLine(), out Y))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        Console.WriteLine($"Результат умножения: {mult(X, Y)}");
                        break;
                        
             
                    case 4:

                        int Z = 0;
                        Console.WriteLine("Введите число Z");
                        while (!analizeInputData(Console.ReadLine(), out Z))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        int Q = 0;
                        Console.WriteLine("Введиет число Q");
                        while (!analizeInputData(Console.ReadLine(), out Q))
                        {
                            Console.WriteLine("Введите целое число");
                            continue;
                        }

                        if (Q == 0) 
                        Console.WriteLine("Деление на ноль невозможно");
                        else
                        Console.WriteLine($"Результат деления: {div(Z, Q)}");

                        


                        break;
                }
            }
        }

        private static bool analizeInputData(string userText, out int convertValue)
        {
            if (!int.TryParse(userText, out convertValue)) return false;
            
            return true;
        }



        private static int summary(int a, int b)
        {
            return a + b;
        }

        private static int sub(int d, int c)
        {
            return d - c;
        }

        private static int mult(int x, int y)
        {
            return x * y;
        }

        private static int div(int z, int q)
        {
            return z / q;
        }

      


    }
}
