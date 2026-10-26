
namespace Gcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a (a >= 0): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b (b >= 0): ");
            int b = int.Parse(Console.ReadLine());

            // Проверка некорректного ввода
            if (a < 0 || b < 0 || (a == 0 && b == 0))
            {
                Console.WriteLine("Ошибка: числа должны быть >= 0 и не равны нулю одновременно.");
                return;
            }

            // Алгоритм Евклида строго по псевдокоду
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine($"НОД (вывод a) = {a}");
        }
    }
}
