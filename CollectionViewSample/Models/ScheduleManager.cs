using System;
using System.Collections.Generic;

namespace CollectionViewSample.Models
{
    public class ScheduleManager
    {
        public ScheduleManager()
        {
        }

        public List<Schedule> Get()
        {
            return new List<Schedule>()
            {
                new Schedule
                {
                    Time = new DateTime(2020,1,8,4,50,00),
                    Title ="起床",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,5,28,00),
                    Title ="出勤",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,6,30,00),
                    Title ="出社",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,9,10,00),
                    Title ="朝会",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,12,00,00),
                    Title ="起床",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,17,30,0),
                    Title ="退社",
                },
            };
        }
    }
}
