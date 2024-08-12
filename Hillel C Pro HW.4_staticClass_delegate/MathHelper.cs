
using System.Numerics;

partial class Program
{
    //Завдання 1: Статичний клас для математичних обчислень
    //Створіть статичний клас MathHelper, який містить такі методи:
    public static class MathHelper
    {
       

        //Factorial(int n): обчислює факторіал числа.
        public static long Factorial(int n) 
        {

            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);

        }
        //GCD(int a, int b): знаходить найбільший спільний дільник (НСД) двох чисел.
        public static int GCD(int a, int b) 
        {
            while (b != 0)
            { 
            int temp = b;
                b = a%b;
                a = temp;
            }
            int result;
            result = a;
            Console.WriteLine("Результат:  " + result);
            return result;
        }
        //LCM(int a, int b): знаходить найменше спільне кратне (НСК) двох чисел.
        public  static int LCM(int a, int b) 
        {
            int result = Math.Abs(a * b) / GCD(a, b);
            Console.WriteLine("Результат:  " + result);
            return result;


        }


    //done
    }
}
