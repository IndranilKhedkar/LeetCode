using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Linq;

namespace Recursion
{
    /// <summary>
    /// Gnerate all the strings of n bits. Assume A[0..n – 1] is an array of size n.
    /// </summary>
    [RelatedTopic(Topic.Recursion)]
    public class NBitStrings : Question
    {
        readonly int[] A = new int[5];

        public void GenerateBinaryStrings(int n)
        {
            if (n < 1)
            {
                Console.WriteLine(string.Join(',', A).ToString());
            }
            else
            {
                A[n - 1] = 0;
                GenerateBinaryStrings(n - 1);
                A[n - 1] = 1;
                GenerateBinaryStrings(n - 1);
            }
        }

        public override void Run()
        {
            // Example 1
            GenerateBinaryStrings(5);
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
