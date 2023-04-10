/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numN)
{

    int counter = Convert.ToString(numN).Length;
    int intermediate = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        intermediate = numN - numN % 10;
        result = result + (numN - intermediate);
        numN = numN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine($"{numberN} -> {sumNumber}");