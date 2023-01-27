using System;

// schedule meeting only on days i.e business day only

namespace Enumeration
{
    public enum days: byte // by default byte
    {
        Monday = 1, Friday = 3, Saturday = 8
    }

    internal class RealExamleEnum
    {

        // creaing our own
        public static days MeetingDay { get; set; } = days.Monday; // default is monday

        static void Main(string[] args)
        {
            MeetingDay = days.Monday; // here i can now only set meetingday to monday friday or saturday.
            Console.WriteLine(MeetingDay);

            Console.ReadLine();
        }
    }
}
