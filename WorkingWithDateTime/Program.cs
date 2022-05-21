using System;

namespace WorkingWithDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2021, 4, 12); //Returns 12/04/2021 12:00:00 AM
            var now = DateTime.Now; //Returns 23/04/2021 11:42:00 AM
            var mth = DateTime.Now.Month; //4
            var newMth = DateTime.Now.AddMonths(2); //23/06/2021 11:51:18 AM

            var formatedDt = String.Format("{0:MM MMMM, yyyy}", dt); //04 Apr 2021

            //DotNet recommends us to use DateTimeOffset
            var localTimeWithTimeZone = DateTimeOffset.Now; // 23/04/2021 11:42:00 AM +10:00

            TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone); // 23/04/2021 11:54:22 AM

            var timeSpan = new TimeSpan(60, 100, 200); //2.13:43:20
            var totalDays = timeSpan.TotalDays;        //2.57175925925926
            var totalHours = timeSpan.TotalHours;      //61.7222222222222

            TimeSpan diff = now - dt; //11.12:29:08.3354108
        }
    }
}
