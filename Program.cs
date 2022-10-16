// Напишите цикл. который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
int result(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
    result = result * a;    
    }
return result;
}
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(result(a,b));
