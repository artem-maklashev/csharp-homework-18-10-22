/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumber(string message)
{
    
    Console.Write(message);
    int result = 0;
    bool isCorrect = false;
    
    while (!isCorrect)
    if (int.TryParse(Console.ReadLine(), out result))
        isCorrect= true;
    else
        Console.Write("Было введено не число. Повторите ввод: ");
    Console.WriteLine();
    return result;
}

(double, double) TakeCoordinates(int k1, int b1, int k2, int b2)
{
    double coordinateX;
    double coordinateY;

    coordinateX = (double)(b2-b1)/(k1-k2);
    coordinateY = (double)(b1*k2-b2*k1)/(k2-k1);

    return (coordinateX, coordinateY);
}

Console.Clear();
Console.WriteLine("Давайте определим точку пересечения прямых задданных уравнениями\ny = k1 * x + b1, y = k2 * x + b2\n");
int k1 = GetNumber("Введите k1 ->");
int b1 = GetNumber("Введите b1 ->");
int k2 = GetNumber("Введите k2 ->");
int b2 = GetNumber("Введите b2 ->");

(double xCorr, double yCorr) = TakeCoordinates(k1, b1, k2, b2);

Console.WriteLine($"Точка пересечения прямых y = {k1} * x + {b1}, y = {k2} * x + {b2}\nнаходится в координатах ({xCorr}, {yCorr})\n");



