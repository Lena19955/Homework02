int GetNumberFromUser()
{
  Console.Write("Введите число от 100 до 999: ");
  int temp = int.Parse(Console.ReadLine());
  return temp;
}

bool IsValid(int number)
{
  return number >= 100 && number <= 999;
}

int GetNumber(int value)
{
  int b = (value / 10) % 10;

  return b;
}

string GetText(int input, int output)
{
  return input + " -> " + output;
}

void Task10()
{
  int value = GetNumberFromUser();

  if (IsValid(value))
  {
    int result = GetNumber(value);
    System.Console.WriteLine(GetText(value, result));
  }
  else
  {
    System.Console.WriteLine("Число не трехзначное");
  }
}
Task10();

