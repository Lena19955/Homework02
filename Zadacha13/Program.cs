Console.Write("Введите число: ");
  int N = int.Parse(Console.ReadLine());
if (N < 100)
{
   System.Console.WriteLine("нет третьей цифры");
}
else  {
while (N >= 1000){
  N = N-1000;
}
N = N / 100;
System.Console.WriteLine(N);
}
