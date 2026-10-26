АЛГОРИТМ Подсчет_Цифр
ВХОД: n (целое неотрицательное число)
ВЫХОД: sum (сумма цифр), count (количество цифр)

НАЧАЛО
    ИНИЦИАЛИЗАЦИЯ:
        sum = 0
        count = 0
        temp = n

    ЦИКЛ-С-ПОСТУСЛОВИЕМ
        last_digit = temp MOD 10
        sum = sum + last_digit
        count = count + 1
        temp = temp DIV 10
    ПОКА temp > 0

    ВЫВОД count, sum
КОНЕЦ
