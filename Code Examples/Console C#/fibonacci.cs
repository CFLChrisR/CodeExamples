/* This program calculates possible combinations for an increment of 1,2, or 3. 
Example would be a child running up the stairs and they take 1,2,3 steps at a time. 
This will calculate the number of steps taken using O(n3) "oh n cubed" time complexity. 
As step number increase n will increase exponentially.*/

using System;

namespace test_code_from_paper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string n = Console.ReadLine();
                int computecalculations(int p)
                {
                    if (p == 0)
                    {
                        return 0;
                    }
                    if (p == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return ((((p - 1)) + (p - 2)) + (p - 3));
                    };
                }
                Console.WriteLine(computecalculations(Convert.ToInt32(n)));
            }
        }
    }
}


