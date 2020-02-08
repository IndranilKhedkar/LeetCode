using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections.Generic;

namespace Recursion
{
    [RelatedTopic(Topic.Recursion)]
    public class MagicMatrix : Question
    {
        static List<int[]> numsList = new List<int[]>();
        static int[] arr = new int[4];
        static int rows = 2;
        static int cols = 2;
        static int target = 1;
        static int result = 0;

        public override void Run()
        {
            GeneratePermutations(rows * cols);
            Console.WriteLine(result);
        }

        private static void GeneratePermutations(int number)
        {
            GeneratePermutationsRecusiveHelper(number);

            foreach (var nums in numsList)
            {
                int rowCounter = 0;
                int colCounter = 0;

                int rowMult = 1;
                int colMult = 1;
                int colIndex = 0;
                int colNumber = 0;

                bool flag = true;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (rowCounter == rows)
                    {
                        if (rowMult != target)
                        {
                            flag = false;
                            break;
                        }
                        rowCounter = 0;
                        rowMult = 1;
                    }
                    if (colCounter == cols)
                    {
                        if (colMult != target)
                        {
                            flag = false;
                            break;
                        }
                        colCounter = 0;
                        colMult = 1;

                        colIndex = ++colNumber;
                    }

                    rowMult *= nums[i];

                    colMult *= nums[colIndex];
                    colIndex += cols;

                    rowCounter++;
                    colCounter++;
                }

                if (flag && rowMult == target && colMult == target)
                {
                    result += 1;
                }
            }
        }

        private static void GeneratePermutationsRecusiveHelper(int n)
        {
            if (n < 1)
            {
                int[] temp = new int[rows * cols];
                for (int i = 0; i < rows * cols; i++)
                {
                    temp[i] = arr[i];
                }
                numsList.Add(temp);
            }
            else
            {
                arr[n - 1] = 1;
                GeneratePermutationsRecusiveHelper(n - 1);
                arr[n - 1] = -1;
                GeneratePermutationsRecusiveHelper(n - 1);
            }
        }
    }
}

/*
import java.io.*;
import java.util.*;

public class Main
{

    static List<int[]> result = new ArrayList<int[]>();
    static int[] arr = null;
    static int rows = 0;
    static int cols = 0;
    static int target = 0;
    static int actualResult = 0;

    public static void main(String args[] ) throws Exception
    {
        Scanner sc = new Scanner(System.in);
    rows = sc.nextInt();
       cols = sc.nextInt();
       int target = sc.nextInt();
    sc.close();
       
       arr = new int[rows * cols];
       System.out.println(rows + " " + cols + " " + target);

    GetPer(rows* cols);
    System.out.println(actualResult);
}

private static void GetPer(int number)
{
    GenerateBinaryStrings(number);
    for (int[] nums : result)
    {

        int rowCounter = 0;
        int colCounter = 0;

        int rowMult = 1;
        int colMult = 1;
        int colIndex = 0;

        for (int i = 0; i < nums.length; i++)
        {
            System.out.print(nums[i]);
            if (rowCounter == (rows - 1))
            {
                if (rowMult != target)
                {
                    break;
                }
                if (i == (nums.length - 1))
                {
                    actualResult += 1;
                }
                rowCounter = 0;
                rowMult = 1;
            }
            if (colCounter == (cols - 1))
            {
                if (colMult != target)
                {
                    break;
                }
                if (i == (nums.length - 1))
                {
                    actualResult += 1;
                }
                colCounter = 0;
                colMult = 1;
                colIndex++;
            }

            rowMult *= nums[i];
            colMult *= nums[colIndex + cols];

            rowCounter++;
            colCounter++;
        }

        System.out.println();
    }
}

private static void GenerateBinaryStrings(int n)
{
    if (n < 1)
    {
        int[] temp = new int[rows * cols];
        for (int i = 0; i < rows * cols; i++)
        {
            temp[i] = arr[i];
        }
        result.add(temp);
    }
    else
    {
        arr[n - 1] = 1;
        GenerateBinaryStrings(n - 1);
        arr[n - 1] = -1;
        GenerateBinaryStrings(n - 1);
    }
}
}
*/
