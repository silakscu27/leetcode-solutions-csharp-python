"""
Problem: Best Time to Buy and Sell Stock
Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

Task:
You are given an array `prices` where `prices[i]` is the price of a stock on the i-th day.
You can buy one stock and sell one stock only once (buy first, then sell later).

Return the maximum profit you can achieve.
If no profit can be made, return 0.

Example:
Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6 - 1 = 5.
"""

# ------------------------------------------------------------
#  Solution 1: Brute Force
# ------------------------------------------------------------
# Time Complexity: O(n^2)
# Space Complexity: O(1)
# Explanation:
#   Check every possible pair (buy, sell) and compute the max profit.
#   Inefficient for large inputs.
# ------------------------------------------------------------

def max_profit_bruteforce(prices):
    max_profit = 0
    for i in range(len(prices)):
        for j in range(i + 1, len(prices)):
            profit = prices[j] - prices[i]
            if profit > max_profit:
                max_profit = profit
    return max_profit


# ------------------------------------------------------------
#  Solution 2: Greedy
# ------------------------------------------------------------
# Time Complexity: O(n)
# Space Complexity: O(1)
# Explanation:
#   Track the minimum price so far and calculate potential profit at each step.
#   Update max profit whenever a higher profit is found.
# ------------------------------------------------------------

def max_profit_greedy(prices):
    min_price = float('inf')
    max_profit = 0

    for price in prices:
        if price < min_price:
            min_price = price
        elif price - min_price > max_profit:
            max_profit = price - min_price

    return max_profit


# ------------------------------------------------------------
#  Test Section
# ------------------------------------------------------------
if __name__ == "__main__":
    prices = [7, 1, 5, 3, 6, 4]

    print("Brute Force:", max_profit_bruteforce(prices))
    print("Greedy :", max_profit_greedy(prices))
