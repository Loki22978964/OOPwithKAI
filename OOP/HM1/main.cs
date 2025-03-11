using System;

public class Array{
    private int[] arr;
    private length;

    public Array(int size){
        if (size < 1) {
            Console.WriteLine("Size must be greater than 0");
        }
        else{
        length = size;
        data = new int[length];
        }
    }

    public int this[int index]{
        get{
       if(index < 0 || index >= length){
        Console.WriteLine("Out of range");
       }
        }
        set{
            if(index < 0 || index >= length){
        Console.WriteLine("Out of range");

        arr[index] = value;
       }
        }
    }


}

public class Program{
    public static void Main(){

    }
}