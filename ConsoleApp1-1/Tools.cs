using System;

namespace ConsoleApp1_1
{
    class Tools
    {
        // Метод для получения названия темы
        public string GetThemeName(int theme)
        {
            switch (theme)
            {
                case 1: return "Методы";
                case 2: return "Условия";
                case 3: return "Циклы";
                case 4: return "Массивы";
                default: return "Неизвестная тема";
            }
        }

        // === БЛОК 1: Методы (типы данных) ===

        public int sumLastNums(int x)
        {
            return (x % 10) + ((x / 10) % 10);
        }

        public bool isPositive(int x)
        {
            return x > 0;
        }

        public bool isUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        public bool isDivisor(int a, int b)
        {
            if (a == 0 || b == 0) return false;
            return (a % b == 0) || (b % a == 0);
        }

        public int lastNumSum(int a, int b)
        {
            return (Math.Abs(a) % 10) + (Math.Abs(b) % 10);
        }

        // === БЛОК 2: Условия ===

        public double safeDiv(int x, int y)
        {
            if (y == 0)
                return 0;
            return (double)x / y;
        }

        public String makeDecision(int x, int y)
        {
            if (x > y)
                return $"{x} > {y}";
            else if (x < y)
                return $"{x} < {y}";
            else
                return $"{x} == {y}";
        }

        public bool sum3(int x, int y, int z)
        {
            return (x + y == z) || (x + z == y) || (y + z == x);
        }

        public String age(int x)
        {
            int lastDigit = Math.Abs(x) % 10;
            int lastTwoDigits = Math.Abs(x) % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                return $"{x} лет";

            switch (lastDigit)
            {
                case 1:
                    return $"{x} год";
                case 2:
                case 3:
                case 4:
                    return $"{x} года";
                default:
                    return $"{x} лет";
            }
        }

        public void printDays(String x)
        {
            switch (x.ToLower())
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    Console.WriteLine("вторник");
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "вторник":
                    Console.WriteLine("вторник");
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "среда":
                    Console.WriteLine("среда");
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "четверг":
                    Console.WriteLine("четверг");
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "пятница":
                    Console.WriteLine("пятница");
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "суббота":
                    Console.WriteLine("суббота");
                    Console.WriteLine("воскресенье");
                    break;

                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;

                default:
                    Console.WriteLine("это не день недели");
                    break;
            }
        }

        // === БЛОК 3: Циклы ===

        public String reverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i + " ";
            }
            return result.Trim();
        }

        public int pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        public bool equalNum(int x)
        {
            if (x < 10) return true;

            int lastDigit = x % 10;
            int temp = x / 10;

            while (temp > 0)
            {
                int currentDigit = temp % 10;
                if (currentDigit != lastDigit)
                    return false;
                temp = temp / 10;
            }
            return true;
        }

        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void guessGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 10);
            int attempts = 0;

            while (true)
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();
                attempts++;

                if (int.TryParse(input, out int userGuess))
                {
                    if (userGuess >= 0 && userGuess <= 9)
                    {
                        if (userGuess == secretNumber)
                        {
                            Console.WriteLine("Вы угадали!");
                            Console.WriteLine($"Вы отгадали число за {attempts} попытки");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Вы не угадали");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 0 до 9");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
        }

        // === БЛОК 4: Массивы ===

        // Задача 4.1 (номер 2 в меню) - Поиск последнего значения
        public int findLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // Задача 4.2 (номер 4 в меню) - Добавление в массив
        public int[] add(int[] arr, int x, int pos)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[pos] = x;

            for (int i = pos; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            return newArr;
        }

        // Задача 4.3 (номер 6 в меню) - Реверс
        public void reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        // Задача 4.4 (номер 8 в меню) - Объединение
        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }

            return result;
        }

        // Задача 4.5 (номер 10 в меню) - Удалить негатив
        public int[] deleteNegative(int[] arr)
        {
            // Сначала посчитаем количество неотрицательных элементов
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    count++;
            }

            // Создаём новый массив нужного размера
            int[] result = new int[count];
            int index = 0;

            // Копируем неотрицательные элементы
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

        // Вспомогательный метод для вывода массива
        public void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        // Вспомогательный метод для создания массива из строки
        public int[] CreateArrayFromString(string input)
        {
            string[] parts = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                arr[i] = int.Parse(parts[i]);
            }

            return arr;
        }
    }
}