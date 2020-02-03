using System;
using System.Collections.Generic;

namespace CollectionViewSample.Models
{
    /// <summary>
    /// リマインダー
    /// </summary>
    public class ScheduleReminder : Schedule
    {
        /// <summary>
        /// 通知。何分前に通知するか。
        /// </summary>
        public List<int> Notifications = new List<int>();

        public ScheduleReminder()
        {
        }
    }
}
