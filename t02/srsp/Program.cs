
class Program
{
    static void Main()
    {
        Console.Write("Введите целое неотрицательное число n: ");
        string input = Console.ReadLine();

        // Проверка корректности ввода
        if (!long.TryParse(input, out long n) || n < 0)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение! Введите целое число >= 0.");
            return;
        }

        long sum = 0;
        long count = 0;
        long temp = n;

        // Цикл do-while гарантирует хотя бы 1 итерацию (для n = 0)
        do
        {
            long digit = temp % 10;
            sum += digit;
            count++;
            temp /= 10;
        } 
        while (temp > 0);

        Console.WriteLine($"Число: {n}");
        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}
