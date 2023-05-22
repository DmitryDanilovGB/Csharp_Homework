//Возведение в квадрат
﻿Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine ("Число " + number + " в квадрате будет равно: " + result);

// является ли первое число квадратом второго.
Console.Write("Введите первое число: ");
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

// период от отрицательного числа к положительному 
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);

while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 1;
}