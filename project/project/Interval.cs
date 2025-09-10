using System;

namespace RPGGame
{
    public struct Interval
    {
        private readonly Random random;
        
        public int Min { get; }
        public int Max { get; }

        public float Get => random.Next(Min, Max + 1);

        public Interval(int minValue, int maxValue)
        {
            random = new Random();
            
            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Invalid input data");
            }
            
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Invalid input data");
            }
            
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("Invalid input data");
            }
            
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Invalid input data");
            }

            Min = minValue;
            Max = maxValue;
        }
    }
}
