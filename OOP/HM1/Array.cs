using System;

public class Array
{
    private int[] arr;
    private int length;

    public Array(int size)
    {
        if (size < 1)
        {
            Console.WriteLine("Size must be greater than 0");
            length = 0;
            arr = new int[0];
        }
        else
        {
            length = size;
            arr = new int[length];
        }
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= length)
            {
                Console.WriteLine("Out of range");
                return default;
            }
            return arr[index];
        }
        set
        {
            if (index < 0 || index >= length)
            {
                Console.WriteLine("Out of range");
                return;
            }
            arr[index] = value;
        }
    }

    public int Length
    {
        get { return length; }
    }
}
