// Problem: Merge Intervals
// Link: https://leetcode.com/problems/merge-intervals/
//
// Task:
// Given a collection of intervals, merge all overlapping intervals
// and return an array of non-overlapping intervals that cover all
// the intervals in the input.
//
// Example:
// Input:  [[1,3],[2,6],[8,10],[15,18]]
// Output: [[1,6],[8,10],[15,18]]

using System;
using System.Collections.Generic;
using System.Linq;

public class MergeIntervalsSolution
{
    // ------------------------------------------------------------
    //  Approach
    // ------------------------------------------------------------
    // 1. Sort the intervals by their start value.
    // 2. Initialize a list with the first interval.
    // 3. For each subsequent interval:
    //      - If it overlaps with the last one, merge them.
    //      - Otherwise, add it as a new interval.
    //
    // Time Complexity: O(n log n)  (for sorting)
    // Space Complexity: O(n)       (for the merged list)
    // ------------------------------------------------------------
    public static int[][] Merge(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return Array.Empty<int[]>();

        // Sort intervals by their start value
        var sorted = intervals.OrderBy(i => i[0]).ToArray();
        var merged = new List<int[]> { sorted[0] };

        foreach (var current in sorted.Skip(1))
        {
            var last = merged[^1]; // last merged interval

            // If overlapping -> merge
            if (current[0] <= last[1])
                last[1] = Math.Max(last[1], current[1]);
            else
                merged.Add(current);
        }

        return merged.ToArray();
    }

    // ------------------------------------------------------------
    //  Test Section
    // ------------------------------------------------------------
    public static void Main()
    {
        int[][] intervals = new int[][]
        {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
        };

        var result = Merge(intervals);

        Console.WriteLine("Input: " + Format(intervals));
        Console.WriteLine("Merged: " + Format(result));
    }

    // Helper method to format array output
    private static string Format(int[][] arr)
    {
        return "[ " + string.Join(", ", arr.Select(a => $"[{a[0]}, {a[1]}]")) + " ]";
    }
}
