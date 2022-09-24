﻿using System;
using System.Collections.Generic;

namespace CSharpBasics;

class Program
{
    public static int[] SquareArrayValues(int[] numArray6)
    {
        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        // For example, [1,5,10,-10] should become [1,25,100,100]
        for (int idx=0;idx<numArray6.Length;idx++)
        {
            Console.WriteLine($"Old Number: {numArray6[idx]}");
            numArray6[idx] *= numArray6[idx];
            Console.WriteLine($"New Number: {numArray6[idx]}");
        }
        return numArray6;
    }
    public static void EliminateNegatives(int[] numArray7)
    {
        // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        for (int idx=0;idx<numArray7.Length;idx++)
        {
            if(numArray7[idx]<0)
            {
                Console.WriteLine($"Old Number: {numArray7[idx]}");
                numArray7[idx]=0;
                Console.WriteLine($"New Number: {numArray7[idx]}");
            }
        }
    }
    public static int[] MinMaxAverage(int[] numArray8)
    {
        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
        int max = numArray8[0];
        int min = numArray8[0];
        int sum = 0;
        for (int idx=1;idx<numArray8.Length;idx++)
        {
            sum += numArray8[idx];
            if(max<numArray8[idx])
            {
                max=numArray8[idx];
            } 
            if(min>numArray8[idx])
            {
                min=numArray8[idx];
            } 
        }
        int average = sum/numArray8.Length;
        int[] answer = {max,min,average};
        Console.WriteLine($"Max: {max} Min: {min} Average: {average}");
        return answer;
    }
    public static void ShiftValues(int[] numArray9)
    {
        // Given an integer array, say [1, 5, 10, 7, -2], 
        // Write a function that shifts each number by one to the front and adds '0' to the end. 
        // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
        // it should become [5, 10, 7, -2, 0].
        for (int idx=0;idx<numArray9.Length;idx++)
        {
            Console.WriteLine($"Old Number: {numArray9[idx]}");
            if (numArray9[idx] == numArray9[numArray9.Length-1])
            {
                numArray9[idx] = 0;
            }
            else 
            {
                numArray9[idx] = numArray9[idx+1];
            }
            Console.WriteLine($"New Number: {numArray9[idx]}");
        }
    }
    public static object[] NumToString(int[] numArray10)
    {
        // Write a function that takes an integer array and returns an object array 
        // that replaces any negative number with the string 'Dojo'.
        // For example, if array "numbers" is initially [-1, -3, 2] 
        // your function should return an array with values ['Dojo', 'Dojo', 2].
        object[] newArray = new object[numArray10.Length];
        for (int idx=0;idx<numArray10.Length;idx++)
        {
            Console.WriteLine($"Old Value: {newArray[idx]}");
            if(numArray10[idx]<0)
            {
                newArray[idx] = "Dojo";
            }
            else
            {
                newArray[idx] = numArray10[idx];
            }
            Console.WriteLine($"New Value: {newArray[idx]}");
        }

        return newArray;
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        //BasicAlgorithms.PrintTo255_For();
        //BasicAlgorithms.PrintTo255_Do_While();
        //BasicAlgorithms.PrintTo255_While();
        //BasicAlgorithms.PrintOddsTo255_For();
        //BasicAlgorithms.PrintOddsTo255_Do_While();
        //BasicAlgorithms.PrintOddsTo255_While();
        //BasicAlgorithms.PrintSum_For();
        //BasicAlgorithms.PrintSum_Do_While();
        //BasicAlgorithms.PrintSum_While();
        //BasicAlgorithms.IterateArray_For(TestValues.TestIntegerArray);
        //BasicAlgorithms.IterateArray_Do_While(TestValues.TestIntegerArray);
        //BasicAlgorithms.IterateArray_While(TestValues.TestIntegerArray);
        
        //BasicAlgorithms.FindMaximumValue_For(TestValues.TestIntegerArray);
        //BasicAlgorithms.FindMaximumValue_Do_While(TestValues.TestIntegerArray);
        //BasicAlgorithms.FindMaximumValue_While(TestValues.TestIntegerArray);
        
        // BasicAlgorithms.FindAverageValue_For(TestValues.TestAverageArray);
        // BasicAlgorithms.FindAverageValue_Do_While(TestValues.TestAverageArray);
        // BasicAlgorithms.FindAverageValue_While(TestValues.TestAverageArray);

        BasicAlgorithms.FindOddValues_For(TestValues.TestIntegerArray);
        BasicAlgorithms.FindOddValues_Do_While(TestValues.TestIntegerArray);
        BasicAlgorithms.FindOddValues_While(TestValues.TestIntegerArray);
        
        BasicAlgorithms.FindGreaterThanYValues_For(TestValues.TestIntegerArray,5);
        BasicAlgorithms.FindGreaterThanYValues_Do_While(TestValues.TestIntegerArray,5);
        BasicAlgorithms.FindGreaterThanYValues_While(TestValues.TestIntegerArray,5);
        // PrintOdds();
        // PrintSum();
        /*int[] numArray2 = {1,12,3,4,6};
        LoopArray(numArray2);*/
        /*int[] numArray2 = {0,26,-6,4,6,-26};
        FindMax(numArray2);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        GetAverage(numArray2);*/
        // OddArray();
        /*int[] numArray2 = {2, 10, 3,-5,0};
        int Y = 8;
        GreaterThanY(numArray2, Y);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        SquareArrayValues(numArray2);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        EliminateNegatives(numArray2);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        MinMaxAverage(numArray2);*/
        /*int[] numArray2 = {2, 10, 3, -5, 0, 6};
        ShiftValues(numArray2);*/
        /*int[] numArray2 = {2, 10, 3, -5, 0, 6};
        NumToString(numArray2);*/
    }
}