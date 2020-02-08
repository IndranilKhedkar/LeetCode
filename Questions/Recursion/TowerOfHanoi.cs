using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;

namespace Recursion
{
    /// <summary>
    /// Algorithm:
    /// • Move the top n – 1 disks from Source to Auxiliary tower
    /// • Move the nth disk from Source to Destination tower
    /// • Move the n – 1 disks from Auxiliary tower to Destination tower
    /// • Transferring the top n – 1 disks from Source to Auxiliary tower can again be thoughtof as a fresh problem and can be solved in the same manner. 
    ///   Once we solve Towersof Hanoi with three disks, we can solve it with any number of disks with the above algorithm.
    /// </summary>
    [RelatedTopic(Topic.Recursion)]
    public class TowerOfHanoi : Question
    {
        public TowerOfHanoi(int n)
        {
            if (n < 1)
                return;

            TowerofHanoiRecursion(n, 'F', 'T', 'A');
        }

        public override void Run()
        {
            // Do nothing
        }

        public void TowerofHanoiRecursion(int n, char fromPeg, char toPeg, char auxPeg)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from peg {fromPeg} to peg {toPeg}");
                return;
            }

            TowerofHanoiRecursion(n - 1, fromPeg, auxPeg, toPeg);

            Console.WriteLine($"Move disk from peg {fromPeg} to peg {auxPeg}");

            TowerofHanoiRecursion(n - 1, auxPeg, toPeg, fromPeg);
        }
    }
}
