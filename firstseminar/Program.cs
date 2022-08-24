//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numa = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Первое число " + numa);

Console.WriteLine("Введите второе число: ");

int numb = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("The second number is " + numb);

if (numa > numb)
{
    Console.WriteLine ("Первое число " + numa + " больше второго " + numb);
}
else if (numa < numb)
{
    Console.WriteLine ("Второе число " + numb + " больше первого " + numa);
}


//Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num1 > max)
{
    max = num1;
}
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.Write("Максимальное число = " + max); 


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Введите число: ");

int num = Convert.ToInt32 (Console.ReadLine ());

if (num % 2==0)

{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine ("Число нечетное");
}


//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (num <=1)

{
    Console.WriteLine("Число слишком маленькое. Введите число больше 1");
} 
else
{
    Console.Write($"Все четные числа от 1 до " + num + " :");
}
while (i <= num)
{
    Console.Write(i + " ");
    i = i+2;
}

    