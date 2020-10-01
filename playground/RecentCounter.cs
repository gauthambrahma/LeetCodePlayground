using System;
using System.Collections.Generic;
using System.Linq;

namespace playground
{
    public class RecentCounter
    {

        public List<int> itemsInRange = new List<int>();
        int currentMin = 0;
        int currentMax = 0;
        public RecentCounter()
        {

        }

        public int Ping(int t)
        {
            currentMin = t - 3000;
            currentMax = t;
            if (itemsInRange.Count == 0)
            {
                itemsInRange.Add(t);
            }
            else
            {
                itemsInRange.RemoveAll(item => item < currentMin || item > currentMax);
                itemsInRange.Add(t);
            }
            return itemsInRange.Count;
        }
    }
}
