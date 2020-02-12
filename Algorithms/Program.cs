using Algorithms.Contracts;
using Algorithms.Helpers;
using System;

namespace Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var topicWiseQuestions = new[]
            {
                QuestionsHelper.ArrayAndStringsQuestions,
                QuestionsHelper.MathQuestions,
                QuestionsHelper.HashTableQuestions,
                QuestionsHelper.HashSetQuestions,
                QuestionsHelper.BitManipulationQuestions,
                QuestionsHelper.StackQuestions,
                QuestionsHelper.DynamicProgrammingQuestions,
                QuestionsHelper.TreeQuestions,
                QuestionsHelper.ConcurrencyQuestions,
                QuestionsHelper.RecursionQuestions,
                QuestionsHelper.LinkedListQuestions,
                QuestionsHelper.GeneralQuestions
            };

            foreach (var topicQuestions in topicWiseQuestions)
            {
                foreach (Question question in topicQuestions)
                {
                    Console.WriteLine($"***** Executing: {question.Name} *****");

                    question.Run();

                    Console.WriteLine("****************************************************************");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to quit");
            Console.ReadLine();
        }
    }
}
