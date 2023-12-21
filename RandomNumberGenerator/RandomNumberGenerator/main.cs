using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    internal class Main
    {
        private double k;
        public (List<double>, double) Genertate(double multiplier, double seed, double increment, double modulus, double iterations)
        {
            double value, cycleLength;
            List<double> randomNumbers = new List<double>();

            randomNumbers.Add(seed);
            k = modulus - 1;

            cycleLength = GetCycleLength(modulus, increment, multiplier, seed);
            if(CheckDuplicates(cycleLength, modulus, increment, multiplier, seed))
            {
                for(double i = 1; i < iterations; i++)
                {
                    value = ((multiplier * randomNumbers.Last()) + increment) % modulus;
                    randomNumbers.Add(value);
                }
                return (randomNumbers, cycleLength);
            }
            return (randomNumbers, -1);
        }

        private double GetCycleLength(double modulus, double increment, double multiplier, double seed)
        {
            /*Case 1*/
            if (IsPowerOf2(modulus) && increment != 0)
                if(IsRelativePrime(increment, modulus) && multiplier == (1 + (4 * k)))
                    return modulus;

            /*Case 2*/
            else if (IsPowerOf2(modulus) && increment == 0)
                if ((seed % 2 != 0) && (multiplier == (5 + (8 * k)) || multiplier == (3 + (8 * k))))
                    return modulus / 4;

            /*Case 3*/
            else if (IsPrime(modulus) && increment == 0)
                    if ((Math.Pow(multiplier, k) - 1) % modulus == 0)
                        return modulus - 1;

            /*Default*/
            return BruteFoceCycleLength(modulus, increment, multiplier, seed);
        }
        private bool IsPowerOf2(double num)
        {
            while(num != 1)
            {
                if (num % 2 != 0)
                    return false;
                num /= 2;
            }
            return true;
            /*return (Math.Ceiling(Math.Log(num, 2)) == Math.Floor(Math.Log(num, 2)));*/
        }

        private double GCD(double a, double b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        private bool IsRelativePrime(double increment, double modulus)
        {
            /*double count = Math.Min(increment, modulus);

            for (double i = 2; i <= count; i++)
                if (increment % i == 0 && modulus % i == 0)
                    return false;
            return true;*/
            return (GCD(increment, modulus) == 1);
               
            /*GCD*/
 /*           double tmp;
            while (modulus != 0)
            {
                tmp = modulus;
                modulus = increment % modulus;
                increment = tmp;
            }
            return increment == 1;*/
        }
        private bool IsPrime(double num)
        {
            if (num % 2 == 0)
                return false;
            for (double i = 3; i <= Math.Sqrt(num); i+=2)
                if (num % i == 0)
                    return false;
            return true;
        }

        private double BruteFoceCycleLength(double modulus, double increment, double multiplier, double seed)
        {
            double value = ((multiplier * seed) + increment) % modulus, cycleLength = 1;
            for (; seed != value; cycleLength++)
                value = ((multiplier * value) + increment) % modulus;
            
            return cycleLength;
        }

        private bool CheckDuplicates(double cycleLength, double modulus, double increment, double multiplier, double seed)
        {
            List<double> tmp = new List<double>();
            double value = ((multiplier * seed) + increment) % modulus;
            for (double i = 1; i < cycleLength; i++)
            {
                value = ((multiplier * value) + increment) % modulus;
                if (tmp.Contains(value))
                    return false;
                tmp.Add(value);
            }
            return true;
        }
    }
}
