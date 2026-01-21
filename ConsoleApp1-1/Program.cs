using System;

namespace ConsoleApp1_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tools Tool1 = new Tools();
            int infinite = 0;
            int x = 0, y = 0;

            // Главный цикл программы
            while (true)
            {
                // Выбор темы
                while (infinite == 0)
                {
                    Console.WriteLine("Выберите тему задач (Введите одну цифру):");
                    Console.WriteLine("1) Методы");
                    Console.WriteLine("2) Условия");
                    Console.WriteLine("3) Циклы");
                    Console.WriteLine("4) Массивы");
                    Console.WriteLine("0) Выход из программы");
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        if (x == 0)
                        {
                            Console.WriteLine("Программа завершена.");
                            return;
                        }
                        if (x >= 1 && x <= 4) break;
                        else Console.WriteLine("Введите число от 1 до 4");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect Input");
                    }
                }

                // Цикл для выбора заданий
                while (true)
                {
                    // Выбор номера задания
                    while (infinite == 0)
                    {
                        Console.WriteLine($"\nВыбранная тема: '{Tool1.GetThemeName(x)}'");
                        if (x == 1 || x == 2 || x == 3 || x == 4)
                        {
                            Console.WriteLine("Выберите номер задания (2, 4, 6, 8 или 10)");
                        }
                        Console.WriteLine("Или введите 0 для выбора другой темы");
                        try
                        {
                            y = int.Parse(Console.ReadLine());
                            if (y == 0) break;
                            if (x == 1 || x == 2 || x == 3 || x == 4)
                            {
                                if (y == 2 || y == 4 || y == 6 || y == 8 || y == 10) break;
                                else Console.WriteLine("Введите допустимый номер задания");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Incorrect Input");
                        }
                    }

                    // Если ввели 0 - выходим из цикла заданий (возврат к выбору темы)
                    if (y == 0) break;

                    // Выполнение задания
                    switch (x)
                    {
                        case 1: // Методы
                            switch (y)
                            {
                                case 2:
                                    Console.WriteLine("\nМетод для возвращения суммы двух последних цифр числа.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите целое число для обработки методом:");
                                            int num1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.sumLastNums(num1));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("\nМетод для проверки: положительное число, или нет.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите целое число для обработки методом:");
                                            int num2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.isPositive(num2));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 6:
                                    Console.WriteLine("\nМетод для проверки: заглавная буква, или нет.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите один символ для обработки методом:");
                                            char chr1 = char.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.isUpperCase(chr1));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 8:
                                    Console.WriteLine("\nМетод для проверки: делится ли одно число на другое нацело.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите первое целое число для обработки методом:");
                                            int a = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите второе целое число для обработки методом:");
                                            int b = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.isDivisor(a, b));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 10:
                                    Console.WriteLine("\nМетод для подсчёта суммы последних цифр двух чисел.");
                                    Console.WriteLine("Многократный вызов метода с числами: 5, 11, 123, 14, 1");
                                    try
                                    {
                                        int result = Tool1.lastNumSum(5, 11);
                                        Console.WriteLine($"1. lastNumSum(5, 11) = {result}");

                                        result = Tool1.lastNumSum(result, 123);
                                        Console.WriteLine($"2. lastNumSum({result}, 123) = {result}");

                                        result = Tool1.lastNumSum(result, 14);
                                        Console.WriteLine($"3. lastNumSum({result}, 14) = {result}");

                                        result = Tool1.lastNumSum(result, 1);
                                        Console.WriteLine($"4. lastNumSum({result}, 1) = {result}");

                                        Console.WriteLine("\nФинальный результат:");
                                        Console.WriteLine(result);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Incorrect Input");
                                    }
                                    break;
                            }
                            break;

                        case 2: // Условия
                            switch (y)
                            {
                                case 2:
                                    Console.WriteLine("\nМетод для безопасного деления (деление на 0 возвращает 0).");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите первое целое число (делимое):");
                                            int num1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите второе целое число (делитель):");
                                            int num2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.safeDiv(num1, num2));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("\nМетод для сравнения двух чисел со знаком операции.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите первое целое число:");
                                            int num1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите второе целое число:");
                                            int num2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.makeDecision(num1, num2));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 6:
                                    Console.WriteLine("\nМетод проверяет, можно ли сложить два числа чтобы получить третье.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите первое целое число:");
                                            int num1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите второе целое число:");
                                            int num2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите третье целое число:");
                                            int num3 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.sum3(num1, num2, num3));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 8:
                                    Console.WriteLine("\nМетод для правильного склонения слова 'год'.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите возраст (целое число):");
                                            int ageNum = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.age(ageNum));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 10:
                                    Console.WriteLine("\nМетод выводит дни недели начиная с указанного.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите день недели (например: 'понедельник'):");
                                            string day = Console.ReadLine();
                                            Console.WriteLine("Результат работы метода:");
                                            Tool1.printDays(day);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;
                            }
                            break;

                        case 3: // Циклы
                            switch (y)
                            {
                                case 2:
                                    Console.WriteLine("\nМетод выводит числа от введенного до 0.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите целое число:");
                                            int num1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.reverseListNums(num1));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("\nМетод возводит число в степень.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите число:");
                                            int baseNum = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Введите степень:");
                                            int power = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.pow(baseNum, power));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 6:
                                    Console.WriteLine("\nМетод проверяет, все ли цифры числа одинаковы.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите целое число:");
                                            int num1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Console.WriteLine(Tool1.equalNum(num1));
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 8:
                                    Console.WriteLine("\nМетод рисует треугольник из звёздочек.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите высоту треугольника:");
                                            int height = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Результат работы метода:");
                                            Tool1.leftTriangle(height);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 10:
                                    Console.WriteLine("\nМетод 'Угадайка' - угадайте число от 0 до 9.");
                                    Console.WriteLine("Результат работы метода:");
                                    Tool1.guessGame();
                                    break;
                            }
                            break;

                        case 4: // Массивы
                            switch (y)
                            {
                                case 2:
                                    Console.WriteLine("\nМетод находит индекс последнего вхождения числа в массив.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите массив чисел через запятую (например: 1,2,3,4,2,2,5):");
                                            string arrayInput = Console.ReadLine();
                                            int[] arr = Tool1.CreateArrayFromString(arrayInput);

                                            Console.WriteLine("Введите число для поиска:");
                                            int searchNum = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Результат работы метода:");
                                            int result = Tool1.findLast(arr, searchNum);
                                            Console.WriteLine($"Индекс последнего вхождения: {result}");
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("\nМетод добавляет элемент в массив на указанную позицию.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите исходный массив через запятую (например: 1,2,3,4,5):");
                                            string arrayInput = Console.ReadLine();
                                            int[] arr = Tool1.CreateArrayFromString(arrayInput);

                                            Console.WriteLine("Введите число для добавления:");
                                            int newNum = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Введите позицию для вставки (начиная с 0):");
                                            int position = int.Parse(Console.ReadLine());

                                            if (position < 0 || position > arr.Length)
                                            {
                                                Console.WriteLine("Позиция должна быть от 0 до " + arr.Length);
                                                continue;
                                            }

                                            Console.WriteLine("Результат работы метода:");
                                            int[] result = Tool1.add(arr, newNum, position);
                                            Tool1.PrintArray(result);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 6:
                                    Console.WriteLine("\nМетод переворачивает массив задом наперёд.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите массив чисел через запятую (например: 1,2,3,4,5):");
                                            string arrayInput = Console.ReadLine();
                                            int[] arr = Tool1.CreateArrayFromString(arrayInput);

                                            Console.WriteLine("Исходный массив:");
                                            Tool1.PrintArray(arr);

                                            Console.WriteLine("Результат работы метода:");
                                            Tool1.reverse(arr);
                                            Tool1.PrintArray(arr);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 8:
                                    Console.WriteLine("\nМетод объединяет два массива в один.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите первый массив через запятую (например: 1,2,3):");
                                            string arrayInput1 = Console.ReadLine();
                                            int[] arr1 = Tool1.CreateArrayFromString(arrayInput1);

                                            Console.WriteLine("Введите второй массив через запятую (например: 7,8,9):");
                                            string arrayInput2 = Console.ReadLine();
                                            int[] arr2 = Tool1.CreateArrayFromString(arrayInput2);

                                            Console.WriteLine("Результат работы метода:");
                                            int[] result = Tool1.concat(arr1, arr2);
                                            Tool1.PrintArray(result);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;

                                case 10:
                                    Console.WriteLine("\nМетод удаляет все отрицательные числа из массива.");
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите массив чисел через запятую (например: 1,2,-3,4,-2,2,-5):");
                                            string arrayInput = Console.ReadLine();
                                            int[] arr = Tool1.CreateArrayFromString(arrayInput);

                                            Console.WriteLine("Исходный массив:");
                                            Tool1.PrintArray(arr);

                                            Console.WriteLine("Результат работы метода:");
                                            int[] result = Tool1.deleteNegative(arr);
                                            Tool1.PrintArray(result);
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Incorrect Input");
                                        }
                                    }
                                    break;
                            }
                            break;
                    }

                    Console.WriteLine("\n────────────────────────────────────");
                }
            }
        }
    }
}