﻿Console.Write("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if(firstnumber == secondnumber * secondnumber)
{
    Console.WriteLine ("Число " + firstnumber + " является квадратом числа: " + secondnumber);
}
else
{
    Console.WriteLine ("Число " + firstnumber + " НЕ является квадратом числа: " + secondnumber);
}


