using ASM_Day3.Business;
using ASM_Day3.Events;

namespace ASM_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock view = new DisplayClock();
            view.Subcrise(clock);
            LogClockToFile log = new LogClockToFile();
            log.Subcribe(clock);
            clock.Run();
        }
    }
}
