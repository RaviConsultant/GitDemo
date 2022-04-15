using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFunction.Calculate
{
    // createing a class Calculate inorder to calculate commision
    public sealed class Calculate
    {
        // Monthly_Com() accept argument in integer type array of month wise and return values
        public int Monthly_Com(int[] m)
        {
            int sum = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] >= 5000) sum += (m[i] / 100) * 3;
                else sum += 0;
            }
            return sum;

        }
        public int Quaterly_Com(int s)
        {
            int r = s / 100;
            if (s >= 20000) return r * 12;
            else if (s >= 15000 && s < 20000) return r * 10;
            else if (s >= 10000 && s < 15000) return r * 5;
            else return 0;
        }


    }
}

