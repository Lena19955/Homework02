Console.WriteLine("Введите число от 1 до 7");
int a = int.Parse(Console.ReadLine());

if((a >= 1) && (a<= 5))
{
Console.WriteLine("Нет");
}
else if((a == 6) || (a ==7))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Вы ввели неверное число");
}

