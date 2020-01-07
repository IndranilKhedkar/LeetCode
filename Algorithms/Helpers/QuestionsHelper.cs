using Algorithms.Contracts;
using Arrays_and_Strings;
using BitManipulation;
using HashTable;
using Math;

namespace Algorithms.Helpers
{
    public static class QuestionsHelper
    {
        public static readonly Question[] ArrayAndStringsQuestions =
            new Question[]
            {
                new DefangingIPAddress(),
                new CellsWithOddValuesInMatrix(),
                new ReplaceElementsWithGreatestElementOnTheRightSide(),
                new SortArrayByParity(),
                new RobotNavigation(),
                new SquaresOfSortedArray(),
                new ArrayPairSum(),
                new MinDeletionsToSortListOfStrings()
            };

        public static readonly Question[] MathQuestions =
            new Question[]
            {
                new SelfDividingNumbers()
            };

        public static readonly Question[] HashTableQuestions =
            new Question[]
            {
                new UniqueNumberOfOccurances()
            };

        public static readonly Question[] BitManipulationQuestions =
            new Question[]
            {
                new HammingDistance()
            };
    }
}
