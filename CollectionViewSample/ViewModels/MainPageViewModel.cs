using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CollectionViewSample.Models;

namespace CollectionViewSample.ViewModels
{
    public class MainPageViewModel
    {
        protected ScheduleManager _manager;

        public string PageTitle { get => "Co"; }

        public ObservableCollection<ScheduleViewModel> Schedules { get; set; } = new ObservableCollection<ScheduleViewModel>();

        public MainPageViewModel()
        {
            _manager = new ScheduleManager();

            List<Schedule> schedules = _manager.Get();
            foreach (Schedule schedule in schedules)
            {
                Schedules.Add(new ScheduleViewModel(schedule));
            }
        }
    }
}
