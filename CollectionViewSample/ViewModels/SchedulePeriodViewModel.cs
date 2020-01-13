using System;
using CollectionViewSample.Models;

namespace CollectionViewSample.ViewModels
{
    public class SchedulePeriodViewModel : ScheduleViewModel
    {
        public SchedulePeriod SchedulePeriod { get => (SchedulePeriod)_schedule; }
        public DateTime PeriodTo { get => SchedulePeriod.PeriodTo; }
        public string Memo { get => SchedulePeriod?.Memo; }
        public string Place { get => SchedulePeriod?.Place; }

        public SchedulePeriodViewModel(SchedulePeriod schedule)
            :base (schedule)
        {
        }
    }
}
