using System;

public class Program
{
    public static void Main()
    {
        Array myArray = new Array(5);

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i * 10;
        }

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine($"myArray[{i}] = {myArray[i]}");
        }

        // Перевірка меж
        myArray[10] = 100; // Виведе "Out of range"
    }
}
