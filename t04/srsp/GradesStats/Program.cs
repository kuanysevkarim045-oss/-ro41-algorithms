
namespace GradesStats
{
    // Вспомогательный класс по условию задания
    static class Grades
    {
        public const int Min = 2;
        public const int Max = 5;
        public const int Stop = 0;

        // Метод чтения оценки: нечисловой ввод возвращает как -1
        public static int Read()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            return -1;
        }

        // Проверка корректности оценки (от 2 до 5)
        public static bool IsValid(int g)
        {
            return g >= Min && g <= Max;
        }

        // Вывод итоговой статистики
        public static void PrintStats(int count, int sum, int fives)
        {
            if (count == 0)
            {
                Console.WriteLine("Оценок нет");
            }
            else
            {
                double average = (double)sum / count;
                Console.WriteLine($"Всего оценок: {count}");
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Количество пятерок: {fives}");
                Console.WriteLine($"Средний балл: {average:F2}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            int fives = 0;

            Console.WriteLine("Введите оценки (0 для завершения):");
            int g = Grades.Read();

            while (g != Grades.Stop)
            {
                if (Grades.IsValid(g))
                {
                    count++;
                    sum += g;
                    if (g == 5)
                    {
                        fives++;
                    }
                }
                else if (g != -1)
                {
                    // Если введено число, но оно вне диапазона 2-5 (и не стоп-слово)
                    // В зависимости от логики практической работы некорректные числа можно игнорировать или учитывать
                }

                g = Grades.Read();
            }

            Grades.PrintStats(count, sum, fives);
        }
    }
}
