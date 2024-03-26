// Hackerrank: The Coin Change Problem
// Given an amount and the denominations of coins available, determine how many ways change can be made for amount. 
// There is a limitless supply of each coin type.



using System.Runtime.InteropServices.Marshalling;

class Result {
    public static long GetWays(int n, List<long> c) {
        if (n == 0) return 0;
        if (n == 1) {
            if (c.IndexOf(1) == -1) {
                return 0;
            }
            else {
                return 1;
            }
        }
        var c_values = c.Where(m => m <= n);
        List<List<long>> dp = [];

        foreach (long coin in c_values) {
            for (int i = 1; i <= n; i++) {
                
            }
        }
        return c_values.Count();
    }
}


class Solution {
    public static void Main(string[] args) {
        int amount = 3;
        List<long> denominations = [8, 3, 1, 2];
        
        Console.WriteLine("---------------------------------");
        Console.WriteLine("--> " + Result.GetWays(amount, denominations));
        Console.WriteLine("---------------------------------");

    }
}
