using System.IO;
using ASM_Day3.Events;

namespace ASM_Day3.Business
{
    public class LogClockToFile
    {
        public void Subcribe(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(WriteToFile);
        }

        public void WriteToFile(object clock, TimeInforEventArgs timeInfor)
        {
            string outputString = "Time: " + timeInfor.hour + ":" + timeInfor.minute + ":" + timeInfor.second;
            using (FileStream stream = File.Open("C://LogFileStream.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = new System.Text.UTF8Encoding(true).GetBytes(outputString);
                stream.Write(bytes, 0, bytes.Length);
            }
            StreamWriter writer = new StreamWriter("C://LogFileStreamWriter.txt", true);
            {
                writer.WriteLine(outputString);
            }
        }
    }
}