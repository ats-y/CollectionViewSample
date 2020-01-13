using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using CollectionViewSample.Models;
using Prism.Services;
using Prism.Services.Dialogs;
using Reactive.Bindings;

namespace CollectionViewSample.ViewModels
{
    public class MainPageViewModel
    {
        protected ScheduleManager _manager;

        public string PageTitle { get => "CollectionView Sample"; }

        public ObservableCollection<ScheduleViewModel> Schedules { get; set; } = new ObservableCollection<ScheduleViewModel>();

        public ReactiveCommand TapCommand { get; set; } = new ReactiveCommand();

        protected IPageDialogService _dialogPageService;

        public MainPageViewModel(IPageDialogService dialogPageService)
        {
            _dialogPageService = dialogPageService;
            _manager = new ScheduleManager();

            TapCommand.Subscribe(x => OnTapCommandAsync(x));


            List<Schedule> schedules = _manager.Get();
            foreach (Schedule schedule in schedules)
            {
                if (schedule is SchedulePeriod)
                {
                    Schedules.Add(new SchedulePeriodViewModel((SchedulePeriod)schedule));
                }
                else
                {
                    Schedules.Add(new ScheduleViewModel(schedule));
                }
            }
        }

        private async Task OnTapCommandAsync(object x)
        {
            ScheduleViewModel tappedVm = x as ScheduleViewModel;
            if (x == null) return;

            await _dialogPageService.DisplayAlertAsync("タップ", tappedVm.Title, "OK");
        }
    }
}
