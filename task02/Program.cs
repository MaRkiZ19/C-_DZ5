// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumNotEvenInd(int [] numbers, int Length)
{
    int quant = 0;
    for (int i = 0; i < Length; i++)
    {
        if (i % 2 != 0)
        {
            quant = quant + numbers[i];
        }
    }
    return quant;
}


int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
System.Console.WriteLine($"Сумма значений элементов расположенных на нечетных позициях = {SumNotEvenInd(numbers, Length)}");