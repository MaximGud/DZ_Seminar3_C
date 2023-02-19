﻿// Доп. задание №1:
// Представим банк, в котором алгоритм начисления процента по вкладу 
// зависит от суммы вклада. На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %,
//  если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.

Console.Write("Введите сумму вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());

if (sum < 100)
{
  sum *= 1.05;
}
else if (sum >= 100 && sum <= 200)
{
  sum *= 1.07;
}
else
  sum *= 1.1;

Console.Write($"Сумма вклада с процентами равна {sum:f2}");