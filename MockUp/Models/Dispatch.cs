using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUp.Models
{
    public class Dispatch
    {
        public DateTime ScheduleDate { get; set; }
        public int DispatchID { get; set; }
        public string CompanyName { get; set; }
        public string Time { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }
    }

    public class DispatchManger
    {

        public static List<Dispatch> GetDispatches()
        {
            var dispatches = new List<Dispatch>();

            dispatches.Add(new Dispatch
            {
                ScheduleDate = new DateTime(2017, 11, 26),
                DispatchID = 1,
                CompanyName = "Starbucks",
                Address = "123 Whatevs RD Canonsburg, PA 15317",
                Details = "djsafhj",
                Time = "9:00"
            });
            dispatches.Add(new Dispatch
            {
                ScheduleDate = new DateTime(2017,11,26),
                DispatchID = 2,
                CompanyName = "Target",
                Address = "123 New Ave Canonsburg, PA 15317",
                Details = "djfhsdjfhsdksdfh",
                Time = "10:00"
            });

            dispatches.Add(new Dispatch
            {
                ScheduleDate = new DateTime(2017, 11, 24),
                DispatchID = 3,
                CompanyName = "McDonalds",
                Address = "33 ThisOne RD Canonsburg, PA 15317",
                Details = "hello lars man",
                Time = "11:00"
            });

            dispatches.Add(new Dispatch
            {
                ScheduleDate = new DateTime(2017, 11, 25),
                DispatchID = 4,
                CompanyName = "Wendy's",
                Address = "3 Hello RD Canonsburg, PA 15317",
                Details = "Whatever you want to call it",
                Time = "9:00"
            });

            dispatches.Add(new Dispatch
            {
                ScheduleDate = new DateTime(2017, 11, 24),
                DispatchID = 5,
                CompanyName = "CVS",
                Address = "345 Whatevs RD McMurray, PA 15330",
                Details = "djsafhj",
                Time = "11:00"
            });

            return dispatches;
        }
       
    }


}


