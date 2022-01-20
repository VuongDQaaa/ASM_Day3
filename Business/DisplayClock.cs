using System;
using ASM_Day3.Events;

namespace ASM_Day3.Business
{
    public class DisplayClock
    {
        public void Subcrise(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }
        private void TimeHasChanged(object clock, TimeInforEventArgs args)
        {
            Console.WriteLine("{0}:{1}:{2}", args.hour, args.minute, args.second);
        }
    }
}