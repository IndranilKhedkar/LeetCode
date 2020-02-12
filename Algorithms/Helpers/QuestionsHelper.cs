using Algorithms.Contracts;
using Arrays_and_Strings;
using BitManipulation;
using Concurrency;
using DynamicProgramming;
using General;
using HashSet;
using HashTable;
using LinkedList;
using Math;
using Recursion;
using Stack;
using Tree;

namespace Algorithms.Helpers
{
    public static class QuestionsHelper
    {
        public static readonly Question[] ArrayAndStringsQuestions =
            new Question[]
            {
                new LeetCodeContest(),
                new DefangingIPAddress(),
                new CellsWithOddValuesInMatrix(),
                new ReplaceElementsWithGreatestElementOnTheRightSide(),
                new SortArrayByParity(),
                new RobotNavigation(),
                new SquaresOfSortedArray(),
                new ArrayPairSum(),
                new MinDeletionsToSortListOfStrings(),
                new UniqueEmailAddresses(),
                new StudentsHeightChecker(),
                new TransposeMatrix(),
                new NonDecreasingArray(),
                new FindCommonCharecters(),
                new ReverseString(),
                new OccurancesAfterBigrams(),
                new ShortestDistanceToACharecter(),
                new MinimumAbsoluteDifference(),
                new SearchInsertPosition(),
                new MaximumSubarray(),
                new LengthofLastWordInString(),
                new MergeSortedArrays(),
                new PascalTriangle(),
                new PascalTriangleII(),
                new BestTimetoBuyandSellStock(),
                new Palindrome(),
                new TwoSumIISortedArray(),
                new RotateArray(),
                new ReverseVowelsofaString(),
                new MoveZeroes(),
                new ArrayPartition()
            };

        public static readonly Question[] MathQuestions =
            new Question[]
            {
                new FloorSqrt(),
                new SelfDividingNumbers(),
                new FibonacciNumber(),
                new AddBinaryNumbers(),
                new Math.FindSingleUniqueNumber(),
                new ExcelSheetColumnTitle(),
                new ExcelSheetColumnNumber(),
                new FactorialTrailingZeroes(),
                new ValidPerfectSquare(),
                new AddNumberDigits(),
                new UglyNumber(),
                new HappyNumber(),
                new CountPrimesNumbers()
            };

        public static readonly Question[] HashTableQuestions =
            new Question[]
            {
                new UniqueNumberOfOccurances(),
                new KeyboardRow(),
                new SubdomainVisitCount(),
                new WordsThatCanBeFormedFromSetOfCharecters(),
                new HashTable.FindSingleUniqueNumber(),
                new IsomorphicStrings(),
                new ContainsDuplicateIII()
            };

        public static readonly Question[] HashSetQuestions =
           new Question[]
           {
                new IntersectionofTwoArrays()
           };

        public static readonly Question[] BitManipulationQuestions =
            new Question[]
            {
                new HammingDistance(),
                new BitManipulation.FindSingleUniqueNumber(),
                new Numberof1Bit()
            };

        public static readonly Question[] StackQuestions =
            new Question[]
            {
                new MinStack(),
                new RemoveAllAdjecentDuplicatesInString(),
                new BalancedBracketsII()
            };

        public static readonly Question[] DynamicProgrammingQuestions =
            new Question[]
            {
                new ClimbingStairs()
            };

        public static readonly Question[] TreeQuestions =
            new Question[]
            {
                new BinaryTreeLevelOrderTraversalII()
            };

        public static readonly Question[] ConcurrencyQuestions =
            new Question[]
            {
               new PrintFooBarAlternately()
            };

        public static readonly Question[] RecursionQuestions =
            new Question[]
            {
               new TowerOfHanoi(1),
               new ArraySortedCheck(),
               new KAryStrings(),
               new NBitStrings(),
               new MagicMatrix()
            };

        public static readonly Question[] GeneralQuestions =
            new Question[]
            {
               new FizzBuzz()
            };

        public static readonly Question[] LinkedListQuestions =
           new Question[]
           {
               new RemoveLinkedListElements()
           };
    }
}
