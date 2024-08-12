
using System.Threading.Channels;

partial class Program
{


    //Завдання 4: Делегати та події
    public delegate void Stoptimer();




    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
    static void Main(string[] args)
  { 
      ApplicationSettings settings = new ApplicationSettings();




        while (true)
        {
            Console.WriteLine($"Задание 1: Static classes , MathHelper\n" +
                $"Задание 2: Вложенные Классы\n" +
                $"Задание 3: Generics\n" +
                $"Задание 4: Delegate");
            Console.Write("Введите номер задачи:");
            var consumerQuery = (ProgramFunc)Convert.ToInt32(Console.ReadLine());
            switch (consumerQuery)
            {
                case ProgramFunc.MathHelper:
                    // 1 

                    Console.WriteLine("Задание 1.\n");

                    int y = 7; int x = 7;
                    Console.WriteLine("какую функцию желаете использовать?\n" +
                        "1: Factorial()\n" +
                        "2: GMD\n" +
                        "3: LCM\n");
                    Console.Write("Введите номер задачи:");
                   var consumerQuery1 = (ProgramFunc1)Convert.ToInt32(Console.ReadLine());
                    switch (consumerQuery1) 
                    { 
                        case ProgramFunc1.Factorial:
                            Console.Clear();
                            Console.Write("Введите число факториала:");
                            y = Convert.ToInt32(Console.ReadLine() ?? "7");

                            Console.WriteLine($"результат факториала числа {y} = " + MathHelper.Factorial(y));
                        break;
                        case ProgramFunc1.GCD:
                            Console.Clear();
                            Console.Write("Введите первое число :");
                            y = Convert.ToInt32(Console.ReadLine() ?? "7");
                            Console.Write("Введите второе число :");
                            x = Convert.ToInt32(Console.ReadLine() ?? "7");
                            MathHelper.GCD(y, x);
                            break;
                        case ProgramFunc1.LCM:
                            Console.Clear();
                            Console.Write("Введите первое число :");
                            y = Convert.ToInt32(Console.ReadLine() ?? "7");
                            Console.Write("Введите второе число :");
                            x = Convert.ToInt32(Console.ReadLine() ?? "7");
                            MathHelper.LCM(y, x);
                            break;

                    }
                
                 break;

                // 2

                case ProgramFunc.ApplicationSettings:
                    Console.Clear();
                    Console.WriteLine("Задание 2.\n");
                    settings.programSettings();
                 
                    break;
           


                //done
                //3
                case ProgramFunc.Generic:
                    Console.Clear();
                    //int
                    Storage<int> intStorage = new Storage<int>();
                    Console.Write("Создан объект типа int , введите его значение :");
                    var queryInt = Convert.ToInt32(Console.ReadLine());
                    intStorage.SetItem(queryInt);
                    Console.WriteLine($"INT = " + intStorage.GetItem());
                    // string
                    Storage<string> stringStorage = new Storage<string>();
                    Console.Write($"Создан объект типа string , введите его значение :");
                    var queryString = Console.ReadLine() ?? "Empty string";
                    stringStorage.SetItem(queryString);
                    Console.WriteLine($"string = " + stringStorage.GetItem());
                    // double 

                    break;

                //4
                case ProgramFunc.Delegate:
                    Console.Clear();
                    Timer timer = new Timer();
                    Console.Write("Задайте время таймера : ");
                    timer.OnTimeElapsed += () => { Console.WriteLine("Таймер остановлен!"); };
                    var queryTimer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("вызван таймер на " + queryTimer +" секунд \nОжидайте..");
                    timer.Start(queryTimer);
                    //возможно асинхронность решит проблему точек
                    //for (int i = 0; i < queryTimer; i++)
                    //{ 
                    //Thread.Sleep(1000);
                    //    Console.Write(".");
                    //}
                    break;
            }
        }

    }
}
