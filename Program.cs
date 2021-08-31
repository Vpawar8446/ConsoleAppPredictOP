using System;

namespace ConsoleAppPredictOP
{
    enum MeetingImportance
    {
        Trivial,
        Regular,
        Critical,
    }
    class Program
    {
        static void Main(string[] args)
        {
            MeetingImportance meet = MeetingImportance.Critical;
            int value = (int)MeetingImportance.Critical;

            if (meet == MeetingImportance.Critical)
            {
                Console.WriteLine("Regular : " + value);

            }
            else if (meet == MeetingImportance.Regular)
            {
                Console.WriteLine("Critical : " + value);
            }

            else if (meet == MeetingImportance.Trivial)
            {
                Console.WriteLine("Trivial : " + value);
            }

        }
    }
}
