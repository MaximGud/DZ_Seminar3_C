// Доп. задание №2:
// Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по величине цифре. Напишите программу,
//  которая определяет интересное число или нет. Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();
int i = 0;  
int size = stringNumber.Length;

char c = stringNumber[i];
// char c = '1';
// int i = c - '0'; // i is now equal to 1, not '1'
int max = c - '0';
char b = stringNumber[i];
int min = b - '0';
while (i < size)
{
  if ((int)Char.GetNumericValue(stringNumber[i]) > max)
  {
    max = (int)Char.GetNumericValue(stringNumber[i]);
  }
  else if ((int)Char.GetNumericValue(stringNumber[i]) < min)
  {
    min = (int)Char.GetNumericValue(stringNumber[i]);
  }
  i++;
}
if (i == stringNumber.Length)
{
  i = 0;
}
int sredneeZn = max - min;

while (i < size)
  if (sredneeZn == (int)Char.GetNumericValue(stringNumber[i]))
  {
    Console.WriteLine("Число интересное");
    return;
  }
  else
  {
    i++;
  }
Console.WriteLine("Число не интересное");
