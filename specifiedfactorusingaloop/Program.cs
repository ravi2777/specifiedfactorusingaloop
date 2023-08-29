using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int factor = 2;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= factor;
        }

        Console.WriteLine("Array after multiplication: " + string.Join(", ", array));
    }
}
