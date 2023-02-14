/*
 Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result ))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено неверное число! Повторите ввод!");
        }
    }

    return result;
}

int GetNumberNumbers(int num)
{
    int sumPositiveNumbers = 0;
    int number = 0;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        number = GetNumber("Введите целое число: ");
        array[i] = number;
        if (number > 0)
        {
            sumPositiveNumbers = sumPositiveNumbers + 1;
        }
                
    }

    PrintArray(array);
      

    return sumPositiveNumbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int number = GetNumber("Сколько чисел вы хотите ввести?");
int result = GetNumberNumbers(number);
Console.WriteLine();
Console.WriteLine($"Из {number} введённых чисел {result} положительных!");


