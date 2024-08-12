
partial class Program
{
    // done






    //Завдання 3: Дженеріковий клас "Сховище"
    //Створіть дженеріковий клас Storage<T>, який дозволяє зберігати один елемент типу T.
    public class Storage<T> 
{ 
 private T? _item;

    //Додайте методи SetItem(T item) для встановлення значення і GetItem() для отримання значення.
   public void SetItem(T item) { _item = item; }

        public T? GetItem() { return _item; }

    //Перевірте роботу класу з різними типами даних (наприклад, з int, string, користувацькими класами).
}
}
