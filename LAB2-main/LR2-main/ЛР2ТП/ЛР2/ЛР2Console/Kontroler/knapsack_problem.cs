using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР2Console.Kontroler
{
    public class knapsack_problem
    {
        public static List<int> knapsack(int[] cash, int[] cost, int need)
        {
            List<int> mybag = new List<int>();
            int n = cash.Length; 
            int[,] dp = new int[need + 1, n + 1];
            for (int j = 1; j <= n; j++)
            {
                for (int c = 1; c <= need; c++)
                {
                    if (cash[j - 1] <= c)
                    {
                        dp[c, j] = Math.Max(dp[c, j - 1], dp[c - cash[j - 1], j - 1] + cost[j - 1]);
                    }
                    else
                    {
                        dp[c, j] = dp[c, j - 1];
                    }
                }
            }
            int maxp = dp[need, n], a = need;
            for (int i = n; i >= 0; i--)  
            {
                if (maxp <= 0)  
                    break;
                if (maxp == dp[a, i - 1])  
                    continue;
                else
                
                {
                    
                    mybag.Add(i - 1);
                    maxp -= cost[i - 1];  
                    a -= cash[i - 1];
                }
            }
            mybag.Add(dp[need, n]);
            return mybag;
        }
    }
}
    
 
