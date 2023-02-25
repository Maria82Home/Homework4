/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++) array[i] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

Console.Write("Input quantity of elements:");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size,min,max);
ShowArray(newArray);
*/

//Homework4
//Task1. Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

/*
int AinB(int a, int b)
{
  int result = 1;
  for(int i = 1; i <= b; i++) result = result * a;
  return result;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AinB(num1,num2));
*/

//Task2.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumofNumbers(int number)
{
  int sum = 0;
  while(number > 0)
  {
    sum = sum + number % 10;
    number = number / 10;
  }
  return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumofNumbers(num));
*/

//Task3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    Console.Write("Input element of array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(GetArray(size));