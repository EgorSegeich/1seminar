Console.WriteLine("введите первое числ: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quotient = number1 / number2;

if(quotient == number2)
{
Console.Write("Yes");
}
else
{
Console.Write("no");
}