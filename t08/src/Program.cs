using System;
using System.Text;

namespace AlgorithmLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProcessStringTrimming();
            ProcessTryParseExample();
            DemonstrateStringVsStringBuilder();
            DemonstrateStringImmutability();
        }

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
                if (!int.TryParse(part, out int value))
                {
                    return false;
                }
            }
            return true;
        }

        public static void DemonstrateStringVsStringBuilder()
        {
            Console.WriteLine("--- Задание 3: string vs StringBuilder ---");

            string strResult = "";
            for (int i = 0; i < 4; i++)
            {
                strResult += i; 
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(i);
            }
            string sbResult = sb.ToString();

            Console.WriteLine($"Результат string: {strResult} (Создано 5 объектов string)");
            Console.WriteLine($"Результат StringBuilder: {sbResult} (Создан 1 объект StringBuilder)\n");
        }

        public static void DemonstrateStringImmutability()
        {
            string s = "привет";
            
            Console.WriteLine("--- Задание 4: Неизменяемость строк ---");
            Console.WriteLine($"До ToUpper(): {s}");

            s.ToUpper(); 
            Console.WriteLine($"После s.ToUpper() без присваивания: {s}");

            s = s.ToUpper();
            Console.WriteLine($"После s = s.ToUpper(): {s}\n");
        }
    }
}
