using System;
using CollectionViewSample.Models;

namespace CollectionViewSample.ViewModels
{
    /// <summary>
    /// スケジュール表示用ViewModel
    /// </summary>
    public class ScheduleViewModel
    {
        /// <summary>
        /// 表示対象のスケジュール。
        /// </summary>
        protected Schedule _schedule;

        public DateTime Time { get => _schedule.Time; }
        public string Title { get => _schedule.Title; }

        public ScheduleViewModel(Schedule schedule)
        {
            _schedule = schedule;
        }

    }
}
