// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNumber(int number)
    {
     if(number < 100 ^ number > 999) 
    {
        Console.WriteLine($"Введенное число {number} не является трехзначным"); 
     }
    else // если все ок
    {
        int length_number = number % 100 / 10; 
         Console.WriteLine($"Вторая цифра числа {number} является {length_number}");
     }
 }

Console.Write("Введите трехначное число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
SecondNumber(num_1);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Find_3_Number(int number) // объявляем метод

 {
     string number_text = Convert.ToString(number); 
     if(number_text.Length > 2) Console.WriteLine($"Длина всего числа: {number_text.Length} Третья цифра числа \"{number}\" является \"{number_text[2]}\""); 
     else Console.WriteLine($"Число \"{number}\" не имеет третьей цифры"); 
 }
Console.Write("Введите число: "); 
int num_1 = Convert.ToInt32(Console.ReadLine()); 

 Find_3_Number(num_1);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 void FindNumberWeek(int number) // объявляем метод
    {
     if(number < 1 ^ number > 7) Console.WriteLine($"Введенное число {number} меньше одного или больше семи, введите число от 1 до 7");
     if(number >= 6 & number < 8)Console.WriteLine("Данный день является выходным");
     if(number >= 1 & number <= 5)Console.WriteLine("Данный день не является выходным");
    }
Console.Write("Введите число от одного до семи: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

FindNumberWeek(num_1);