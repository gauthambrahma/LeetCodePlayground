using System;
using System.Collections.Generic;
using System.Linq;

namespace playground
{
    public class NonOverLappingIntervals
    {
        public static void notMain() {
            List<Interval> intervalList = new List<Interval>();
            intervalList.Add(new Interval(1, 2));
            intervalList.Add(new Interval(2, 3));
            intervalList.Add(new Interval(3, 4));
            intervalList.Add(new Interval(1, 3));

            intervalList.OrderBy(x=>x.End).ToList();
        
        }
    }

    public class Interval
    {
        public Interval(int start, int end) {
            this.Start = start;
            this.End = end;
        }
        public int Start { get; set; }
        public int End { get; set; }
    }
}
