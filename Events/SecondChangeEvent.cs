using System;
using System.Threading;

namespace ASM_Day3.Events
{
    public class Clock
    {
        private int _hour;
        private int _minute;
        private int _second;
        public delegate void SecondChangeHandler(object clock, TimeInforEventArgs args);
        public event SecondChangeHandler SecondChange;
        protected void OnSecondChange(object clock, TimeInforEventArgs args)
        {
            if (SecondChange != null)
            {
                SecondChange(clock, args);
            }
        }
        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(1000);
                DateTime dateTimeNow = DateTime.Now;
                if (dateTimeNow.Second != _second)
                {
                    TimeInforEventArgs timeInforEventArgs = new TimeInforEventArgs(dateTimeNow.Hour, dateTimeNow.Minute, dateTimeNow.Second);
                    OnSecondChange(this, timeInforEventArgs);
                }

                this._hour = dateTimeNow.Hour;
                this._minute = dateTimeNow.Minute;
                this._second = dateTimeNow.Second;
            }
        }

    }
}