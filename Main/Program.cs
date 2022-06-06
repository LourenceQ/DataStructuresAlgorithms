﻿using LienarSearchUnsorted;
using LinearSearchSorted;
using BinarySearch;
using BinarySearchRecursion;
using FirstRepeatedElementInArray;
using static System.Console;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 45, 3, 78, 9, 3, 4 };
            int[] arr2 = { 1, 3, 3, 4, 9, 43, 78 };
            int[] arr3 = { 1, 45, 3, 78, 9, 3, 4, 1, 45 };
            int[] arr4 = new int[] { 34, 56, 77, 1, 5, 6, 6, 6, 6, 6, 6, 7, 8, 10, 34, 20 };

            int value = 4;
            int value2 = 78;

            var res1 = LienarSearchUnsortedClass
                .LinearSearchUnsortedMethod(arr3, value);

            var res2 = LinearSearchSortedClass
                .LinearSearchSortedMethod(arr3, value);

            var res3 = BinarySearchClass
                .BinarySearchMethod(arr2, value2);

            var res4 = BinarySearchRecursionClass
                .BinarySearchRecursionMethod(arr2, arr2.Length, value2);

            var res5 = FirstRepeatedBruteForce
                .FirstRepeated(arr);

            WriteLine(
                $"LienarSearchUnsorted: {res1}\n" +
                $"LienarSearchSorted: {res2}\n" +
                $"BinarySearchRecursion: {res3}\n" +
                $"BinarySearchRecursion: {res4}\n" +
                $"FirstRepeatedElementBruteForce: {res5}");
            FirstRepeatedHashTable.FirstRepeatedHash(arr3);

        }
    }
}
