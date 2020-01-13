using System;
using CollectionViewSample.Models;

namespace CollectionViewSample.ViewModels
{
    public class ScheduleViewModel
    {
        protected Schedule _schedule;

        public ScheduleViewModel(Schedule schedule)
        {
            _schedule = schedule;
            Title = _schedule.Title;
        }

        public DateTime Time { get => _schedule.Time; }

        public string Title { get; set; }

    }
}
