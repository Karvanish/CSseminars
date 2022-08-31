// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(long number) // создаем
 {
     string number_text = Convert.ToString(number); // конвертируем
     int length_number = number_text.Length; // высчитываем длину
     int i = 1; // создаем переменную
     int unequal = 0; // еще переменная
     int iteration = length_number / 2; // считаем количество итераций
     int index = 1;
     if(number < 10 && number > -10)
     {
         Console.Write($"Введите число больше двух знаков");
     }
     else
     {
         if (number < 0)
             {
                 index = 0;
             }
             while(iteration < length_number) // количество итераций меньше длины
             {
                iteration ++; // увеличиваем счетчик
                 if(number_text[i - index]  != number_text[length_number - i]) // сравниваем по одному символу
                 {
                 i ++; // увеличиваем счетчик
                 unequal ++; // увеличиваем счетчик
                 }
             }
             if (unequal > 0) Console.Write($"Число {number} не является палиндромом"); // если не равно
             else Console.Write($"Число {number} является палиндромом и в обратном порядке будет {number}"); // если равно
     }
    
 }

 Console.Write("Введите число: "); // запрашиваем число
 long num_1 = Convert.ToInt64(Console.ReadLine()); // получаем от пользователя число
 Palindrom(num_1); // запускаем метод

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 void DistanceXYZ(double x1, double x2, double y1, double y2, double z1, double z2) // создаем метод
 {
     double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)); // считаем
     Console.Write($"Расстояние между точками в 3D пространстве: {distance}"); // выводим
 }
 Console.Write("Введите первое число кординаты X: "); // запрашиваем число
 double Xa = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя Xa
 Console.Write("Введите второе число кординаты X: "); // запрашиваем число
 double Xb = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя Xb

 Console.Write("Введите первое число кординаты Y: "); // запрашиваем число
 double Ya = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя Ya
 Console.Write("Введите второе число кординаты Y: "); // запрашиваем число
 double Yb = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя Yb

 Console.Write("Введите первое число кординаты Z: "); // запрашиваем число
 double Za = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя Za
 Console.Write("Введите второе число кординаты Z: "); // запрашиваем число
 double Zb = Convert.ToDouble(Console.ReadLine()); // получаем от пользователя Zb

 DistanceXYZ(Xa, Xb, Ya, Yb, Za, Zb); применяем метод

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

 void Cube(int number) // создаем метод
 {
     int i = 1; // создаем начальный индекс
     if(number > 0) // число меньше нуля
     {
     while(i <= number) // количество итераций
         {
             if(i == number) Console.Write($"{i * i * i}"); // убираем запятую вконце 
             else Console.Write($"{i * i * i}, "); // считаем
             i ++; // счетчик +1
         }
     }
     else // в другом случае
     {
        Console.Write($"Вы ввели \"{number}\", данное число меньше или равно \"0\", введите число больше \"0\""); // сообщение при 0 и меньше
     }

 }
 Console.Write("Введите число: "); // просим ввести число
 int numb_1 = Convert.ToInt32(Console.ReadLine()); // ввод числа
 Cube(numb_1); // запускаем метод