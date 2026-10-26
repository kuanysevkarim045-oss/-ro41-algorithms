
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введите количество секунд: ");
        string input = Console.ReadLine();

        // Проверка на корректность ввода (целое число)
        if (!int.TryParse(input, out int totalSeconds))
        {
            Console.WriteLine("Ошибка: введено не целое число.");
            return;
        }

        // Проверка на отрицательное число
        if (totalSeconds < 0)
        {
            Console.WriteLine("Ошибка: количество секунд не может быть отрицательным.");
            return;
        }

        // Вычисления
        int hours = totalSeconds / 3600;
        int remainder = totalSeconds % 3600;
        int minutes = remainder / 60;
        int seconds = remainder % 60;

        // Вывод результата
        Console.WriteLine($"{totalSeconds} сек. = {hours} ч. {minutes} мин. {seconds} сек.");
    }
}