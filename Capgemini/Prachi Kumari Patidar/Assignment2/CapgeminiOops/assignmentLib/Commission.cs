using System;

namespace Ford.assignmentLib
{
    public class Commission
    {
        //Monthly Minimum sales Commission :
        public float Monthly_Commission(int[] m, int s)
        {

            float sum = 0;

            if (m[0] >= 12000 && m[1] >= 12000 && m[2] >= 12000) sum += (s / 100) * 2.45f;
            else if (m[0] >= 7500 && m[1] >= 7500 && m[2] >= 7500) sum += (s / 100) * 1.25f;
            else sum += 0;
            return sum;

        }

        //Quarterly overall sales Commission :
        public float Quaterly_Commission(int s)
        {
            float r = s / 100;
            if (s >= 50000) return r * 5.0f;
            else if (s >= 30000) return r * 4.5f;
            else if (s >= 20000) return r * 3.75f;
            else if (s >= 15000) return r * 2.5f;
            else if (s >= 10000) return r * 1.75f;

            else return 0;
        }
    }
}
