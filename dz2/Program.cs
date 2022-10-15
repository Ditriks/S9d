// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
FindNatural(n, m);
void FindNatural(int n, int a = 1)
{
    sum = sum + a;
    a++;
    
    if(a > n )
        return;
    FindNatural(n, a);
}
Console.WriteLine($"Сумма чисел между M и N равна {sum}");
