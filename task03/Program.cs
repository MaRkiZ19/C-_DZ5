//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] CreateArray(int Length, int min, int max)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
        numbers[i] = new Random().Next(min, max +1);
}
return numbers;
}

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

void MinMax(int [] numbers, int Length)
{
    int MaxNum = 0;
    int MimNum = numbers[0];
    for (int i = 0; i < Length; i++)
    {
        if (numbers[i] > MaxNum) MaxNum = numbers[i];
        else if (numbers[i] < MimNum) MimNum = numbers[i];
    }
    System.Console.WriteLine(string.Join(", ", MimNum, MaxNum));
}

/*int Difference(int MimNum, int MaxNum, int result);
{
    int result = 0;
    result = MaxNum - MimNum;
    return result;
}*/



int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
MinMax(numbers, Length);
/*Difference( MinMax(numbers, Length));
System.Console.WriteLine(result);*/
