// Задача 25. Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
/*
int number = 3;
int power = 5;
int result = number;
int count = 1;
while (count < power)
{
    result *= number;
    count++;
}
Console.WriteLine($"Число {number} в степени {power} равно {result}");


int number = 3;
int power = 5;
Zadacha25(number, power);

void Zadacha25(int currentNumber, int currentPower)
{
    int result = currentNumber;
    int count = 1;
    while (count < currentPower)
    {
        result *= currentNumber;
        count++;
    }
    Console.WriteLine($"Число {currentNumber} в степени {currentPower} равно {result}");
}


// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

string string_number27 = "56543";
int number = Convert.ToInt32(string_number27);

Zadacha27(number);

void Zadacha27(int currentNumber)
{
    Console.WriteLine();
    Console.WriteLine("____________");
    Console.WriteLine("Задача 27");
    int sum = 0;
    int startNumber = currentNumber;
    while(currentNumber>0)
    {
        sum += currentNumber%10;
        currentNumber /= 10;
    }
    Console.WriteLine($"В числе {startNumber} сумма цифр равна {sum}");
}
*/

// Задача 29. Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

int[] array = new int[5] {-2, 1, 7, 5, 19};

Console.WriteLine();
Console.WriteLine("____________");
Console.WriteLine("Задача 29");
PrintArray(array);
Zadacha29(array);
PrintArray(array);

void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива на печать...");    
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.WriteLine(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void Zadacha29(int[] currentArray)
{
    int lastIndex = currentArray.Length - 2;
    for (int i = lastIndex; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(currentArray[j]) > Math.Abs(currentArray[j+1]))
            {
                int temp = currentArray[j];
                currentArray[j] = currentArray[j+1];
                currentArray[j+1] = temp;
            }
            
        }
    }
}
