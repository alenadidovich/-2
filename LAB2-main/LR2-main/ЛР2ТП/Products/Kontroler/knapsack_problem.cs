using System;
using System.Collections.Generic;
using System.Text;

namespace Kontroler
{
    public class Knapsack_problem
    {
        public static List<int> knapsack(int[] money, int[] cost, int need)
        {
            List<int> Bagpack = new List<int>();
            int n = money.Length;                                
            int[,] dp = new int[need + 1, n + 1];
            for (int m = 1; m <= n; m++)
            {
                for (int g = 1; g <= need; g++)
                {
                    if (money[m - 1] <= g)
                    {
                        dp[g, m] = Math.Max(dp[g, m - 1], dp[g - money[m - 1], m - 1] + cost[m - 1]);
                    }
                    else
                    {
                        dp[g, m] = dp[g, m - 1];
                    }
                }
            }
            int max = dp[need, n], a = need;
            for (int i = n; i >= 0; i--)                        
            {
                if (max <= 0)                                 
                    break;
                if (max == dp[a, i - 1])                      
                    continue;
                else
                                                               
                {
                                                              
                    Bagpack.Add(i - 1);
                    max -= cost[i - 1];  
                    a -= money[i - 1];
                }                                              
            }
            Bagpack.Add(dp[need, n]);
            return Bagpack;
        }
    }
}
    
 
