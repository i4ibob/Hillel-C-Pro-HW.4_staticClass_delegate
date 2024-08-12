
partial class Program
{




    //Завдання 2: Вкладені класи для керування налаштуваннями
    //Реалізуйте клас ApplicationSettings, який містить вкладений клас DatabaseSettings.
    public class ApplicationSettings
    {

        private DatabaseSettings _databaseSettings;
    //ApplicationSettings має містити поля для зберігання основних налаштувань програми (наприклад, назва програми, версія).
    public string? nameOfProgram = "my program";
    public double versionProgram = 1.1;

       public  ApplicationSettings () 
       {
            _databaseSettings = new DatabaseSettings();

       }

                private class DatabaseSettings
                {//DatabaseSettings має містити поля для налаштувань бази даних (наприклад, рядок підключення, таймаут підключення).
                    public string? databaseName { get; set; } = "MyDATAbase";
                  public  string? databaseConnectionString { get; set; } = "my_database_MyDATAbase_connection_string_414606";
                    public string? databasePassword { get; set; } = "PaSWoRd_123QWE";
                    public int databasePort { get; set; } = 65000;
                    public int timeOutConnection { get; set; }  = 1500;
                }
    

     //Створіть метод, що повертає повну інформацію про налаштування програми у вигляді рядка.
        public void programSettings ()
        {
            Console.WriteLine(
                      $"Name of program {nameOfProgram} version {versionProgram} \n" +
                      $"Name of DB  - {_databaseSettings.databaseName} \n" +
                      $"DataBase Connection String =\"{_databaseSettings.databaseConnectionString}\"\n" +
                      $"Port of Connection {_databaseSettings.databasePort}\n" +
                      $"DB Password - {_databaseSettings.databasePassword}\n"
                      );
        }
    }
}
