using KarlMillares_Assessment1.Services;
using System;

namespace KarlMillares_Assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assessment # 1");
            var removedNumber = new Random().Next(1, 101);
            var myNumbers = new Numbers(removedNumber);
            var sortedRemoved = myNumbers.GetRemovedNumberInSorted();
            var unsortedRemoved = myNumbers.GetRemovedNumberInUnsorted();

            Console.WriteLine($"Input array: {string.Join(", ", myNumbers.InputList)}");
            Console.WriteLine($"Removed number: {removedNumber}");
            Console.WriteLine($"");
            Console.WriteLine($"Sorted Numbers: {string.Join(", ", myNumbers.Sorted)}");
            Console.WriteLine($"Removed Number in sorted {sortedRemoved}");
            Console.WriteLine($"");
            Console.WriteLine($"Unsorted Numbers: {string.Join(", ", myNumbers.Unsorted)}");
            Console.WriteLine($"Removed Number in unsorted: {unsortedRemoved}");
            Console.ReadLine( );
        }
    }
}
