//Завдання 1: Статичний клас для математичних обчислень
//Створіть статичний клас MathHelper, який містить такі методи:
static class MathHelper
{



    //Factorial(int n): обчислює факторіал числа.
    static void Factorial(int n) { }
    //GCD(int a, int b): знаходить найбільший спільний дільник (НСД) двох чисел.
    static void GCD(int a, int b) { }
    //LCM(int a, int b): знаходить найменше спільне кратне (НСК) двох чисел.
    static void LCM(int a, int b) { }
    
}




//Завдання 2: Вкладені класи для керування налаштуваннями
//Реалізуйте клас ApplicationSettings, який містить вкладений клас DatabaseSettings.
class ApplicationSettings
{//ApplicationSettings має містити поля для зберігання основних налаштувань програми (наприклад, назва програми, версія).
    string? nameOfProgram;
    double versionProgram;
    class DatabaseSettings
    {//DatabaseSettings має містити поля для налаштувань бази даних (наприклад, рядок підключення, таймаут підключення).
        string? databaseName;
        string? databaceConnectionString;
        string? databasePassword;
        int databasePort;
        int timeOutConnection;
    }

    //Створіть метод, що повертає повну інформацію про налаштування програми у вигляді рядка.
   public string programSettings ()
   {

        string info = "";
        return info;
   }
}







//Завдання 3: Дженеріковий клас "Сховище"
//Створіть дженеріковий клас Storage<T>, який дозволяє зберігати один елемент типу T.
class Storage<T> 
{ 
    //Додайте методи SetItem(T item) для встановлення значення і GetItem() для отримання значення.
    void SetItem(T item) { }
    void GetItem() { }
    //Перевірте роботу класу з різними типами даних (наприклад, з int, string, користувацькими класами).
}


//Завдання 4: Делегати та події
//Створіть клас Timer, який буде працювати як простий таймер.
class Timer 
{
   
    void Start(int seconds) 
    {

    }
}
//Клас повинен мати метод Start(int seconds), який буде викликати подію OnTimeElapsed після закінчення вказаного часу.
//Подія OnTimeElapsed повинна бути типу Action і спрацьовувати, коли таймер закінчить відлік.
//Створіть програму, яка використовує цей таймер, і підпишіться на подію, щоб виводити повідомлення на екран після завершення таймера.