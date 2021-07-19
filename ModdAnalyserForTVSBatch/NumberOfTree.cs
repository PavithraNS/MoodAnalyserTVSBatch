using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModdAnalyserForTVSBatch
{
    class NumberOfTree
    {
        //T(0)=1
        //T(1)=1
        //T(2)=T(0)*T(1)+T(1)*T(0)
        public static int NumberOfTrees(int n)
        {
            if (n <= 1) return 1;

            int sum = 0;
            int left = 0, right = 0;

            for (int i = 1; i <= n; i++)
            {
                left = NumberOfTrees(i - 1);
                right = NumberOfTrees(n - i);
                sum += (left * right);
            }
            return sum;
        }
    }
}
