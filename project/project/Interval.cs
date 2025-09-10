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
                Console.WriteLine("Некорректные входные данные");
            }
            
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Некорректные входные данные");
            }
            
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("Некорректные входные данные");
            }
            
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Некорректные входные данные");
            }

            Min = minValue;
            Max = maxValue;
        }
    }
}
