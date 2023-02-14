/*
Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1
                                  y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)
{
    double result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result ))
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

void IntersectionPoint()
{
    double b1 = GetNumber("Введите значение b1: ");
    double b2 = GetNumber("Введите значение b2: ");
    double k1 = GetNumber("Введите значение k1: ");
    double k2 = GetNumber("Введите значение k2: ");
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
    Console.WriteLine($"Пересечение в точке Х = {x} и Y = {y}");

    

}

IntersectionPoint();
 

 

