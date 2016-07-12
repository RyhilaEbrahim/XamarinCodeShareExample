using System;

namespace NewApp
{
    public class SharedClass
    {
        public SharedClass()
        {
        }
        private int Count { get; set; }

        public string IncreaseCount()
        {
            Count++;
            return $"You clicked {Count} time";
        }
    }
}

