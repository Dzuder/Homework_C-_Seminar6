using static System.Console;
Clear();

// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


WriteLine("Эта программа, найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2\n \nДля этого нужно ввести значения");


WriteLine("Введите значение k1:");
double k1 = double.Parse(ReadLine()!);
WriteLine("Введите значение b1:");
double b1 = double.Parse(ReadLine()!);
WriteLine("Введите значение k2:");
double k2 = double.Parse(ReadLine()!);
WriteLine("Введите значение b2:");
double b2 = double.Parse(ReadLine()!);



double x = XCoordinate(k1, b1, k2, b2);
WriteLine((k1 == k2 && b1 == b2) ?
"Эти прямые совпадают!!"
 : k1 == k2 ? "Эти прямые параллельны!!!"
 : $"Координаты точки пересечения этих прямых ({Math.Round(x, 2)}; {Math.Round((k1 * x + b1), 2)}) ");





double XCoordinate(double a1, double c1, double a2, double c2)
{
    double res = (c2 - c1) / (a1 - a2);
    return res;
}
