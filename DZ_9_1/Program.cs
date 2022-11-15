using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

class CustomArray<T>
{
    T[] array;
    public CustomArray(int count)
    {
        array = new T[count];
    }
    public CustomArray<T> this[int index]
    {
        get => this[index];
        set => this[index] = value;
    }
    public void Arrayfill(T op1, T op2)
    {
        array[0] = op1;
        Console.WriteLine(op1);
        array[1] = op2;
        Console.WriteLine(op2);
    }
    public void ArrayWrite(int count)
    {
        for(int i = 0; i<count; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    public void Sort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}


public class A
{
    public int op1;
    public A(int op1)
    {
        this.op1 = op1;
        Console.WriteLine(op1);
    }
}

class Programm{ 
    static void Main()
    {
        A op1 = new A(1);
        A op2 = new A(10);
        int count = 2;
        CustomArray<A> arraya = new CustomArray<A>(count);
        arraya.Arrayfill(op1, op2);
        arraya.ArrayWrite(count);
    }
}
