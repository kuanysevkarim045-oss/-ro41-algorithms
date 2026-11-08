using System;
using System.Text;

namespace AlgorithmLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Демонстрация работы Trim и Split
            ProcessStringTrimming();

            // 2. Демонстрация безопасного парсинга (TryParse)
            ProcessTryParseExample();

            // 3. Сравнение производительности: string vs StringBuilder
            DemonstrateStringVsStringBuilder();

            // 4. Демонстрация неизменяемости строк (Immutability)
            DemonstrateStringImmutability();
        }

        /// <summary>
        /// 1. Обработка строки с помощью Trim() и Split(';')
        /// </summary>
        public static void ProcessStringTrimming()
        {
            string s = "  Ахметов Ерлан;85 ";
            string trimmed = s.Trim();
            string[] parts = trimmed.Split(';');

            Console.WriteLine("--- Задание 1: Trim и Split ---");
            Console.WriteLine($"Исходная строка: \"{s}\"");
            Console.WriteLine($"После Trim(): \"{trimmed}\" (Длина: {trimmed.Length})");
            Console.WriteLine($"Элемент [0]: \"{parts[0]}\" (Длина: {parts[0].Length})");
            Console.WriteLine($"Элемент [1]: \"{parts[1]}\" (Длина: {parts[1].Length})\n");
        }

        /// <summary>
        /// 2. Проверка валидности строки оценок через int.TryParse
        /// </summary>
        public static void ProcessTryParseExample()
        {
            string line = "Иванов Пётр;70;85;x";
            bool isValid = TryParseScores(line);

            Console.WriteLine("--- Задание 2: int.TryParse ---");
            Console.WriteLine($"Строка для проверки: \"{line}\"");
            Console.WriteLine($"Результат TryParseScores: {isValid}\n");
        }

        private static bool TryParseScores(string line)
        {
            string[] parts = line.Split(';');
            foreach (string part in parts)
            {
                // Если хотя бы одна часть не является числом, возвращаем false
                if (!int.TryParse(part, out int value))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 3. Сравнение поведения string и StringBuilder в цикле
        /// </summary>
        public static void DemonstrateStringVsStringBuilder()
        {
            Console.WriteLine("--- Задание 3: string vs StringBuilder ---");

            // Использование string (создает 5 объектов в памяти)
            string strResult = "";
            for (int i = 0; i < 4; i++)
            {
                strResult += i; 
            }

            // Использование StringBuilder (эффективное изменение буфера в памяти)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(i);
            }
            string sbResult = sb.ToString();

            Console.WriteLine($"Результат string: {strResult} (Создано 5 объектов string)");
            Console.WriteLine($"Результат StringBuilder: {sbResult} (Создан 1 объект StringBuilder)\n");
        }

        /// <summary>
        /// 4. Демонстрация неизменяемости строк (Immutability)
        /// </summary>
        public static void DemonstrateStringImmutability()
        {
            string s = "привет";
            
            Console.WriteLine("--- Задание 4: Неизменяемость строк ---");
            Console.WriteLine($"До ToUpper(): {s}");

            // Метод ToUpper() возвращает НОВЫЙ объект, но переменную s мы не перезаписываем
            s.ToUpper(); 
            Console.WriteLine($"После s.ToUpper() без присваивания: {s}");

            // Корректный вариант с переприсваиванием ссылки:
            s = s.ToUpper();
            Console.WriteLine($"После s = s.ToUpper(): {s}\n");
        }
    }
}
