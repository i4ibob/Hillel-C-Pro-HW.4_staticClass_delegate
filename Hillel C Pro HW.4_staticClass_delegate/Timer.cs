
partial class Program
{
    //Створіть клас Timer, який буде працювати як простий таймер.

    class Timer 
    {


        //Клас повинен мати метод Start(int seconds), який буде викликати подію OnTimeElapsed після закінчення вказаного часу.

        public event Action OnTimeElapsed;

        public void Start(int seconds) 
        {
            
            Console.WriteLine("Таймер вызван на " + seconds + " секунд");
            Thread.Sleep(1000*seconds);
            OnTimeElapsed?.Invoke();
           
        }
       
        
    //Подія OnTimeElapsed повинна бути типу Action і спрацьовувати, коли таймер закінчить відлік.
    //Створіть програму, яка використовує цей таймер, і підпишіться на подію, щоб виводити повідомлення на екран після завершення таймера.
    }
}
