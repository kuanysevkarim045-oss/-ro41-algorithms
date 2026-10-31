1. Базовый случай и шаг рекурсииБазовый случай: if (n <= 1) return 1;Останавливает рекурсию при $n \le 1$ и возвращает 1.
Шаг рекурсии: return n * F(n - 1);Вызывает функцию с уменьшенным на 1 аргументом и умножает результат на $n$.

import java.util.ArrayList;
import java.util.List;

public class RecursionTable {

    // Рекурсивная функция, которая сохраняет шаги в список
    public static int traceF(int n, int depth, List<String[]> rows) {
        if (n <= 1) {
            rows.add(new String[]{"F(" + n + ")", String.valueOf(depth), "1", "Базовый случай (n <= 1)"});
            return 1;
        }
        
        int subResult = traceF(n - 1, depth + 1, rows);
        int result = n * subResult;
        rows.add(new String[]{"F(" + n + ")", String.valueOf(depth), String.valueOf(result), n + " * F(" + (n - 1) + ") = " + result});
        return result;
    }

    public static void main(String[] args) {
        List<String[]> rows = new ArrayList<>();
        traceF(4, 1, rows);

        System.out.println("=== Трассировка функции F(4) в виде таблицы ===");
        
        // Шапка таблицы
        System.out.println("+-------+---------+------------+--------------------------+");
        System.out.printf("| %-5s | %-7s | %-10s | %-24s |\n", "Вызов", "Глубина", "Возвращает", "Пояснение");
        System.out.println("+-------+---------+------------+--------------------------+");

        // Вывод строк таблицы в правильном порядке
        for (int i = rows.size() - 1; i >= 0; i--) {
            String[] row = rows.get(i);
            System.out.printf("| %-5s | %-7s | %-10s | %-24s |\n", row[0], row[1], row[2], row[3]);
        }
        
        // Нижняя граница таблицы
        System.out.println("+-------+---------+------------+--------------------------+");
    }
}
3. Если заменить n <= 1 на n == 1:

При вызове F(-1) условие n == 1 ложно.

Функция совершает бесконечные рекурсивные вызовы вниз: F(-1) -> F(-2) -> F(-3) -> ...

Память, выделенная под стек вызовов, переполняется.

Результат: Программа аварийно завершается с ошибкой Stack Overflow (переполнение стека).
EOF
