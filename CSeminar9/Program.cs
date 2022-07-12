// Задача 1 С помощью рекрурсии вывести на экран числа от 1 до N
// void ShowNums(int n)
// {
//     if (n != 1)
//         ShowNums(n-1);
//     Console.Write(n + " ");
// }

// ShowNums(5);

// Задача 2 Выввести числа от M до N

// void ShowNums(int n, int m)
// {
//     if (n != m)
//         ShowNums(n-1, m);
//     Console.Write(n + " ");
// }

// ShowNums(5, 2);

// Задача 3 Написать программу, которая будет принимать число и возвращать сумму его цифр

// Console.WriteLine(digitsSum(123));
//      int digitsSum(int number)
//     {
//         if(number==0) return 0;
//         return number % 10 + digitsSum(number/10);
//     }

// Задача 4 Возвести число А в степень Б

// Console.WriteLine(Degree(2,3));

// int  Degree(int A, int B)
//         {
//             if (B > 0) return A * Degree(A, B - 1);
//             else if (B == 0) return 1;
//             else return 1 / (A * Degree(A, -B - 1));
//         }


// -----------------------------------------------------------------
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите меньшее число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите большее число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна {RecSum(m, n)}");

// int RecSum (int min, int max)
// {
//     if (max == min)
//         return min;
//     else return max + RecSum(min, max-1);
// }

// // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество цифр в числе {n} равно {RecDigitCount(n)}");

// int RecDigitCount(int number)
// {
//     if (number < 10)
//         return 1;
//     else return 1 + RecDigitCount(number/10);
// }
//---------------------------------------------------------------------------------------------
// int[] myArray = RandomArray(5);
// Console.WriteLine(RecSum(myArray));
// int[] RandomArray(int size)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(-100, 101);
//         Console.Write(newArray[i] + " ");
//     }
//     Console.WriteLine();
//     return newArray;
// }
// int RecSum(int[] array, int i = 0)
// {
//     if (i >= array.Length)
//     return 0;
//     int result = RecSum(array, i + 1);
//     return array[i] + result;
// }

// string[] MrgeArray(string[] array1, string[] array2)
// {
//     int size = array1.Length;
//     if (size < array2.Length) size = array2.Length;
//     string[] newArray = new string[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = array1[i] + " " + array2[i];
//     }
//     return newArray;
// }

// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     Console.WriteLine(array[i]);
// }
// string[] first = {"Anna", "Ben", "Ted"};
// string[] second = {"hello", "bye", "wow"};

// string[] pip = MrgeArray(first, second);
// PrintArray(pip);

//Задача 1: Задайте массив строк. Напишите программу, которая
//считает кол-во слов в массиве, начинающихся на гласную букву.

string text ="Two roads diverged in a yellow wood "
            +"And sorry I could not travel both "
            +"And be one traveler long I stood "
            +"And looked down one as far as I could "
            +"To where it bent in the undergrowth";

string [] poem = text.Split(new char[]{' '});
Console.WriteLine();
Console.WriteLine($"Количество слов, начинающихся на гласную букву равно {CountVowels(poem)}");

int CountVowels(string [] array)
{
    string vowels = "AaEeIiOoYyUu";
    int count  = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (array[i][0] == vowels[j])
            count++;
        }
    }
    return count;
}

//Задача 2: Задайте массив строк. 
//Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string nameList = "Liam,Olivia,Noah,Emma,Oliver,Charlotte,Elijah,Amelia,James,Anna";
string [] names = nameList.Split(new char[]{','});
PrintArray(MergeElements(names));

string[] MergeElements(string[] incomingArray)
{
    int size = incomingArray.Length / 2;
    if (incomingArray.Length % 2 == 1) size +=1;
    string[] pairs = new string[size];
    if (incomingArray.Length % 2 == 1)
    pairs[size-1] = incomingArray[incomingArray.Length-1];

    int j = 0;
    for (int i = 0; i < incomingArray.Length/2; i++)
    { 
        j = i * 2;
        pairs[i] = incomingArray[j] +  " "  + incomingArray[j+1];
    }
    return pairs; 
}
void PrintArray(string[] array) 
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i] + " ");
}
