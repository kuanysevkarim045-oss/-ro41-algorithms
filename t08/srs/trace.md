
class Program
{
    static void Main()
    {
        // Задание 1: Trim и Split
        string s = "  Ахметов Ерлан;85 ";
        string[] parts = s.Trim().Split(';');
        Console.WriteLine("--- Задание 1 ---");
        foreach (var part in parts)
        {
            Console.WriteLine($"Элемент: \"{part}\" | Длина: {part.Length}");
        }
        Console.WriteLine() 
        // Задание 2: int.TryParse
        string line = "Иванов Пётр;70;85;x";
        string[] lineParts = line.Split(';');
        Console.WriteLine("--- Задание 2 ---");
        for (int i = 0; i < lineParts.Length; i++)
        {
            bool success = int.TryParse(lineParts[i], out int result);
            Console.WriteLine($"Индекс: {i} | Часть: \"{lineParts[i],-12}\" | TryParse: {success,-5} | out: {result}");
        }
        Console.WriteLine();
        // Задание 3: string vs StringBuilder
        Console.WriteLine("--- Задание 3 ---");
        // String (создает новые объекты на каждой итерации)
        string strTest = "";
        for (int i = 0; i < 4; i++)
        {
            strTest += i;
        }
        Console.WriteLine($"String результат: {strTest} (создано 5 объектов string)");
        // StringBuilder (использует изменяемый буфер)
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.Append(i);
        }
        Console.WriteLine($"StringBuilder результат: {sb.ToString()} (создан 1 объект StringBuilder)");
        Console.WriteLine();
        // Задание 4: Immutable строки и ToUpper без присваивания
        Console.WriteLine("--- Задание 4 ---");
        string original = "тест";
        original.ToUpper(); // Возвращает новый объект, но переменная не перезаписывается
        Console.WriteLine($"Значение s после original.ToUpper(): \"{original}\"");
    }
}
