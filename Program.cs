using System;

public class Prorgram
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Please, input string:");
        string str = Console.ReadLine();
        string[] inpArrStr = str.Split(" ");
        
        PrintStringArr(inpArrStr);
        Console.Write(" -> ");
        PrintStringArr(GetResultArray(inpArrStr));
    }

    static void PrintStringArr(string[] array)
    {
    Console.Write($"[ {String.Join(" ",array)} ]");
    }

    static string[] GetResultArray(string[] arrayStr)
    {
        // int size = arrayStr.GetLength(0);
        string[] result = new string[arrayStr.GetLength(0)];
        int count = 0;
        for (int i = 0; i < arrayStr.GetLength(0); i++)
        {
            if (arrayStr[i].Length <= 3)
            {
                result[count] = arrayStr[i];
                count += 1;
            }
        }
        if (arrayStr.GetLength(0)> count) Array.Resize(ref result, count);
        return result;
    }
}

