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
    int max = 0;
    int min = numbers[0];
    for (int i = 0; i < Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
        else if (numbers[i] < min) min = numbers[i];
    }
}

int Difference();
//необходимо вычислить разницу. void MinMax определяет значение минимального и максимального.


int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
MinMax(numbers, Length);
System.Console.WriteLine(Difference());