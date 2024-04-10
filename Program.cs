// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("Введите целое число или 'q' для выхода:");
//             string input = Console.ReadLine();

//             // Проверяем, если введен символ 'q', завершаем программу
//             if (input.ToLower() == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             // Пытаемся преобразовать введенную строку в целое число
//             bool isNumeric = int.TryParse(input, out int number);

//             // Если введено не число, сообщаем об ошибке и просим ввести число заново
//             if (!isNumeric)
//             {
//                 Console.WriteLine("Ошибка! Введите целое число или 'q' для выхода.");
//                 continue;
//             }

//             // Проверяем, если сумма цифр числа чётная, завершаем программу
//             if (IsSumOfDigitsEven(number))
//             {
//                 Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
//                 break;
//             }
//         }
//     }

//     // Метод для проверки чётности суммы цифр числа
//     static bool IsSumOfDigitsEven(int number)
//     {
//         int sum = 0;
//         // Считаем сумму цифр числа
//         while (number != 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//         // Проверяем чётность суммы
//         return sum % 2 == 0;
//     }
// }

