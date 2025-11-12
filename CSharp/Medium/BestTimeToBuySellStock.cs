/*
Problem: Best Time to Buy and Sell Stock
Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

Task:
You are given an integer array `prices` where `prices[i]` represents the price of a stock on the i-th day.
You can buy one share and sell it later — only one transaction allowed.

Return the maximum profit possible. If no profit can be made, return 0.

Example:
Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6 - 1 = 5.
*/


// ------------------------------------------------------------
//  Solution 1: Brute Force
// ------------------------------------------------------------
// Time Complexity: O(n^2)
// Space Complexity: O(1)
// Explanation:
//   For each day, check all future days to find the best selling price.
//   Calculate and store the maximum profit.
// ------------------------------------------------------------

public class SolutionBruteForce {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++) {
            for (int j = i + 1; j < prices.Length; j++) {
                int profit = prices[j] - prices[i];
                if (profit > maxProfit) {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}


// ------------------------------------------------------------
//  Solution 2: One-Pass (Greedy)
// ------------------------------------------------------------
// Time Complexity: O(n)
// Space Complexity: O(1)
// Explanation:
//   Keep track of the minimum price seen so far.
//   At each step, calculate potential profit = currentPrice - minPrice.
//   Update maxProfit if we find a larger value.
// ------------------------------------------------------------

public class SolutionGreedy {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices) {
            if (price < minPrice)
                minPrice = price;
            else if (price - minPrice > maxProfit)
                maxProfit = price - minPrice;
        }

        return maxProfit;
    }
}


// ------------------------------------------------------------
//  Test Section
// ------------------------------------------------------------
public class Program {
    public static void Main(string[] args) {
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        SolutionBruteForce bruteForce = new SolutionBruteForce();
        SolutionGreedy greedy = new SolutionGreedy();

        Console.WriteLine("Brute Force: " + bruteForce.MaxProfit(prices));
        Console.WriteLine("Greedy (One-Pass): " + greedy.MaxProfit(prices));
    }
}
