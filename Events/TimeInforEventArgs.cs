namespace ASM_Day3.Events
{
    public class TimeInforEventArgs
    {
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
        public TimeInforEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}