/*string text = "Папы, мамы и тети Нади нет дома. Они уехали на крестины к тому старому офицеру, "
+ "который ездит на маленькой серой лошади. В ожидании их возвращения Гриша, Аня, Алеша, Соня и кухаркин сын Андрей "
+ "сидят в столовой за обеденным столом и играют в лото. Говоря по совести, им пора уже спать; но разве можно уснуть, "
+ "не узнав от мамы, какой на крестинах был ребеночек и что подавали за ужином.";
// string s = "qwerty";
//             012345
// s[3] // e
string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  
  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
  if (text[i] == oldValue) result = result + $"{newValue}";
  else result = result + $"{text[i]}";
  }
  return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine();
newText = Replace(newText, 'С', 'с'); */

/*int Summa(int a)
{
    int result = 0;
    int count = 1;
    while (count <= a)
    {
        result = result + count;
        count ++;
    }
    return result;
}
Console.WriteLine("Enter your natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum is: " + Summa(num));
*/
/*int Fact(int a)
{
    int result = 1;
    int count = 1;
    while (count <= a)
    {
        result = result * count;
        count ++;
    }
    return result;
}
Console.WriteLine("Enter your natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Fact(num));
*/

/*void Count(int a)
{
    int counter = 0;
    while (a > 0)
    {
        a = a / 10;
        counter++;
    }
    Console.WriteLine("Count of digits in your number is: " + counter);
}
int a = Convert.ToInt32(Console.ReadLine());
Count(a);


int size = 8; // вводим переменную для опроеделения размера массива
int [] array = new int[size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 2); 
}
for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}

int n = 346;
int result = FindSumOfDigits(n);
Console.WriteLine("Sum of digits in your number is: " + result);

int FindSumOfDigits(int num)
{
    int sum = 0;
    while(num > 0)
    {
      sum += num % 10; //sum = sum + num % 10;
      num /= 10; //num = num / 10;
    }
    return sum;
} 

int ArythmSum(int a)
{
    int result = 0;
    int i = 1;
    while (i <= a)
    {
        result = result + i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите ваше целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Cумма чисел от 1 до {numA} равна {ArythmSum(numA)}"); 

int Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result = result * i;
    return result;
}

int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {numA} равно {Factorial(numA)}"); */

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Write("Please enter your first natural number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your second natural number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The result of raising " + a + " to the power of " + b + " is: " + Exponent(a, b));

int Exponent (int x, int y)
{
    int result = (int)Math.Pow(x, y);
    return result;
} */

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 8;
int [] array = new int [size];

Console.WriteLine("Do you want to autofill the array?");
string answer = Console.ReadLine();

if (answer == "yes") 
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101); 
        Console.Write(array[i] + " ");
    }
}

else if (answer == "no")
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write("Add any integer number: ");
        array [index] = Convert.ToInt32(Console.ReadLine());
    }
    foreach(int el in array)
    {
           Console.Write(el + " ");
    }
}

else Console.WriteLine("Please enter 'yes' or 'no'");
    