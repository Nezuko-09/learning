// See https://aka.ms/new-console-template for more information
 /*Console.WriteLine("Hello, World!");
Console.WriteLine("input a number");
int input = int.Parse(Console.ReadLine()!);
if(input < 0 )
{
    Console.WriteLine($"{input} is a negative number");
}
else if (input == 0)
{
    Console.WriteLine("it is zero");
}
else
{
    Console.WriteLine($"{input} is a positive number");
}


Console.WriteLine("days of the week:");
Console.Write("enter a day's number:");
int dayNumber;
bool number = int.TryParse(Console.ReadLine(),out dayNumber);

switch (dayNumber)
{
    case 1:
    Console.WriteLine("Day 1 is Sunday");
    break;
    case 2:
    Console.WriteLine("Day 2 is Monday");
    break;
    case 3:
    Console.WriteLine("Day 3 is Tuesday");
    break;
    case 4:
    Console.WriteLine("Day 4 is Wednesday");
    break;
    case 5:
    Console.WriteLine("Day 5 is Thursday");
    break;
    case 6:
    Console.WriteLine("Day 6 is Friday");
    break;
    case 7:
    Console.WriteLine("Day 7 is Saturday");
    break;
    default:
    Console.WriteLine("input a valid day number");

    break;
}


Console.WriteLine("Hello user!");
Console.WriteLine("enter two numbers:");
int f1= int.Parse(Console.ReadLine()!);
int f2= int.Parse(Console.ReadLine()!);
Console.Write("is the fist number greater? ");
if(f1 > f2)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

Console.Write("Are both numbers equal? ");
if(f1 == f2)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
Console.Write("is at least one of the numbers positive? ");
if(f1 > 0 || f2 > 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


Console.WriteLine("printing numbers from 50 downward");
for (int i = 50; i >= 0 ;)
{
    Console.WriteLine($"{i}");
    i--;
}
*/

Console.WriteLine("sum of even numbers from 1-100: ");

int sum = 0;

for (int i = 2; i <= 100; i += 2)
{
        sum += i;
}
Console.WriteLine($"{sum}");


