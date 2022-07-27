/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
          промежутке от M до N.
            M = 1; N = 5. -> ""1, 2, 3, 4, 5""
            M = 4; N = 8. -> ""4, 6, 7, 8""
          Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
            элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30
          Напишите программу вычисления функции Аккермана с помощью рекурсии.   
            Даны два неотрицательных числа m и n.
            m = 2, n = 3 -> A(m,n) = 29*/
int Acc2(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Acc2(m - 1, 1);
    }
    else
    {
        return Acc2(m - 1, Acc2(m, n - 1));
    }
}



int a, b, sum = 0;
Console.Write("программа выводит числа от М до N\n" +
    "введите первое число: ");
a = int.Parse(Console.ReadLine());
Console.Write("введите второе число:");
b = int.Parse(Console.ReadLine());
    for (; a <= b; a++)
        Console.Write(a + "\t");
    Console.WriteLine();
Console.Write("находит сумму чисел от M до N\n" +
    "введите первое число: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
for (; a <= b; a++)
    sum += a;
Console.WriteLine("сумма = " + sum);
Console.Write("вычисление функци Аккермана \n" +
    "введите два числа :");
Console.WriteLine("первое число: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("второе число: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine(Acc2(a, b));
Console.ReadKey();