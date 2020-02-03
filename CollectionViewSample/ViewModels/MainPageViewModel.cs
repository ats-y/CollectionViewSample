using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using CollectionViewSample.Models;
using Prism.Navigation;
using Prism.Services;
using Reactive.Bindings;

namespace CollectionViewSample.ViewModels
{
    /// <summary>
    /// MainPage ViewModel
    /// </summary>
    public class MainPageViewModel
    {
        /// <summary>
        /// ページタイトル。
        /// </summary>
        public string PageTitle { get => "CollectionView Sample"; }

        /// <summary>
        /// スケジュール一覧。
        /// </summary>
        public ObservableCollection<ScheduleViewModel> Schedules { get; set; } = new ObservableCollection<ScheduleViewModel>();

        /// <summary>
        /// スケジュール管理。
        /// スケジュール一覧に表示するスケジュールを管理する。
        /// </summary>
        protected ScheduleManager _manager;

        /// <summary>
        /// スケジュール一覧の項目タップコマンド。
        /// </summary>
        public ReactiveCommand TapCommand { get; set; } = new ReactiveCommand();

        /// <summary>
        /// ダイアログサービス。
        /// </summary>
        protected IPageDialogService _dialogPageService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dialogPageService"></param>
        public MainPageViewModel(IPageDialogService dialogPageService)
        {
            _dialogPageService = dialogPageService;

            // スケジュール一覧に表示するスケジュールを取得し、項目のViewModelを作成する。
            _manager = new ScheduleManager();

            // スケジュール一覧の項目タップ処理を実装。
            TapCommand.Subscribe(x => OnTapCommandAsync(x));
        }


        /// <summary>
        /// スケジュール一覧の項目タップ処理。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private async Task OnTapCommandAsync(object x)
        {
            ScheduleViewModel tappedVm = x as ScheduleViewModel;
            if (x == null) return;

            await _dialogPageService.DisplayAlertAsync("タップ", tappedVm.Title, "OK");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        public void ShowSchedule()
        {
            Schedules.Clear();

            List<Schedule> schedules = _manager.Get();
            foreach (Schedule schedule in schedules)
            {
                if (schedule is SchedulePeriod)
                {
                    Schedules.Add(new SchedulePeriodViewModel((SchedulePeriod)schedule));
                }
                else if (schedule is ScheduleReminder)
                {
                    Schedules.Add(new ScheduleReminderViewModel((ScheduleReminder)schedule));
                }
                else
                {
                    Schedules.Add(new ScheduleViewModel(schedule));
                }
            }
        }
    }
}
