/*  Задание 1 (Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее)

int num1, num2;

Console.WriteLine("Hi! Please enter first integer number here: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Well done! \nNow please enter second integer number here: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Hey, it's been really easy :) \nmax = " + num1);
}
else
{
    Console.WriteLine("Hey, it's been really easy :) \nmax  = " + num2 + " Let's try something else");
}
*/

/*  Задание 2 
(Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.)

int num1, num2, num3, max;

Console.WriteLine("Please enter your first integer here: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second integer here: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("And now enter your last integer here: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
else 
{
    max = max;
}
Console.WriteLine("Still not a big problem for me :) The largest number is " + max + " Now we can proceed");
*/

/* Задание 3
(Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным)

int num;

Console.WriteLine("Enter your number here: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("The number you entered is even");
}
else
{
    Console.WriteLine("The number you entered is odd");
}
*/

/* Задание 4
(Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N)

int num;

Console.WriteLine("Another game?");
Console.Write("Enter your NATURAL number here: ");
num = Convert.ToInt32(Console.ReadLine());

int ivar = 2;

if (num <= 0)
{
    Console.WriteLine("Fatal Error. The number must be NATURAL.");
    Console.WriteLine("... and they say computers are stupid...");
}
else
{
if (num % 2 == 0) 
{
     while (ivar <= num)
   {
       Console.Write(ivar + " ");
       ivar = ivar + 2;
   }  
}
else
{
    num = num - 1;
    while (ivar <= num)
    {
        Console.Write(ivar + " ");
       ivar = ivar + 2;
    }
}
}
*/

/*  Задание 4 (модификация - программа показывает все четные числа от -N до N)

int num;

Console.WriteLine("Another game?");
Console.Write("Enter your NATURAL number here: ");
num = Convert.ToInt32(Console.ReadLine());

int ivar = num * (-1);

if (num <= 0)
{
    Console.WriteLine("The number must be NATURAL.");
    Console.WriteLine("... and they say computers are stupid...");
}
else
{
if (num % 2 == 0) 
{
     while (ivar <= num)
   {
       Console.Write(ivar + " ");
       ivar = ivar + 2;
   }  
}
else
{
    num = num - 1;
    ivar = num * (-1);
    while (ivar <= num)
    {
        Console.Write(ivar + " ");
       ivar = ivar + 2;
    }
}
}
*/

/* (Напишите программу вычисления модуля числа)
int num;
Console.WriteLine("Enter your number here: ");
num = Convert.ToInt32(Console.ReadLine());

if (num >= 0)
{
    Console.WriteLine("The modulus of your number is " + num);
}
else
{
    num = num * (-1);
     Console.WriteLine("The modulus of your number is " + num);
}
*/

/*  (Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение)
double num;

Console.Write("Please enter a number: ");
num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The answer is: " + 1/num);
*/