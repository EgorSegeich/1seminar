Console.WriteLine("введите номер дня недели: ");
int numberd = Convert.ToInt32(Console.ReadLine());

if(numberd == 1)
{
Console.Write("понедельник");
}

if(numberd == 2)
{
Console.Write("вторник");
}

if(numberd == 3)
{
Console.Write("среда");
}

if(numberd == 4)
{
Console.Write("четверг");
}

if(numberd == 5)
{
Console.Write("пятница");
}

if(numberd == 6)
{
Console.Write("суббота");
}

if(numberd == 7)
{
Console.Write("воскресенье");
}
else
{
Console.Write("введите число от 1 до 7");
}