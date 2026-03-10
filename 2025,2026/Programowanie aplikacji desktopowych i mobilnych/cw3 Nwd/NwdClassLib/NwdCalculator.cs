using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NwdClassLib
{
    public class NwdCalculator
    {
        public int CalculateNwd(int a, int b)
        {
            if(a == 0 && b == 0) 
                throw new ArgumentException("Nwd is not defined");
            a = Math.Abs(a);
            b = Math.Abs(b);
            if(b==0) return a;
            return CalculateNwd(b, a % b);
        }

        public int CalculateNwdIteratively(int a, int b)
        {
            if (a == 0 && b == 0)
                throw new ArgumentException("Nwd is not defined");
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
