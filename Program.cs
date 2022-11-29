// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 //Ошибка в примере. Правильный ответ 4.
int CountPositive(string posArray)
{
    int count=0;
    string[] splitPosArray = posArray.Split(",");
    for (int i=0;i<splitPosArray.Length;i++)
    if (Convert.ToInt32(splitPosArray[i])>0) count++;
    return count;
}
Console.WriteLine("Введите элементы массива через запятую для задачи 41:");
string taskArray = Console.ReadLine();
Console.WriteLine(CountPositive(taskArray));

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("k1 для задачи 43:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("k2 для задачи 43:");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("b1 для задачи 43:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("b2 для задачи 43:");
double b2 = double.Parse(Console.ReadLine());
    if ((k1==k2)&&(b1==b2)) Console.WriteLine("Прямые совпадают");
    else if (k1==k2) Console.WriteLine("Прямые не персекаются");
    else 
    {
        double x = (b2-b1)/(k1-k2); 
        double y = k1*x+b1;
        Console.WriteLine($"Точка пересечения - ({x}, {y})");
    }
