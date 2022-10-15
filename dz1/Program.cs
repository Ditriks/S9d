// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.

/* Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
FindNatural();
void FindNatural()
{
    Console.WriteLine(n);
    n--;
    
    if(a > n)
    {
        return;
    }
    FindNatural();
}
*/

// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
FindNatural(number);
void FindNatural(int number, int counter = 1)
{
    Console.WriteLine(number);
    number--;
    
    if(counter > number)
        return;
    FindNatural(number);
}
