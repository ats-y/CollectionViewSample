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
                new SchedulePeriod
                {
                    Time = new DateTime(2020,1,8,4,50,00),
                    Title = "起床",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,5,28,00),
                    Title = "出勤",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,6,30,00),
                    Title = "出社",
                },
                new SchedulePeriod
                {
                    Time = new DateTime(2020,1,8,9,10,00),
                    PeriodTo = new DateTime(2020,1,8,9,30,00),
                    Title = "朝会",
                    Memo = "お客さんとリモート会議。",
                    Place = "打ち合わせコーナー"
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,12,00,00),
                    Title = "昼休み",
                },
                new ScheduleReminder
                {
                     Time = new DateTime(2020,1,8,13,00,00),
                     Title = "午後一打ち合わせ",
                     Notifications = new List<int>
                     {
                         5,
                         10,
                         20,
                         30,
                     },
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,17,30,0),
                    Title = "退社",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,20,30,0),
                    Title = "夕食",
                },
                new Schedule
                {
                    Time = new DateTime(2020,1,8,23,30,0),
                    Title = "就寝",
                },
            };
        }
    }
}
