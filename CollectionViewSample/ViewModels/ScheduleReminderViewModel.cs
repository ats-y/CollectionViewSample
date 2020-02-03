using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CollectionViewSample.Models;
using Reactive.Bindings;
using Xamarin.Forms;

namespace CollectionViewSample.ViewModels
{
    /// <summary>
    /// リマインダ表示用ViewModel
    /// </summary>
    public class ScheduleReminderViewModel : ScheduleViewModel
    {
        /// <summary>
        /// 通知時間リスト
        /// </summary>
        public ObservableCollection<int> Notifications { get; } = new ObservableCollection<int>();

        /// <summary>
        /// 通知時間表示エリアの表示状態。
        /// true:表示。
        /// </summary>
        public ReactiveProperty<bool> IsExpanded { get; } = new ReactiveProperty<bool>();

        /// <summary>
        /// 通知時間表示切り変えコマンド。
        /// </summary>
        public Command<ScheduleReminderViewModel> ExpandCommand { get; } = new Command<ScheduleReminderViewModel>(x =>
        {
            Debug.WriteLine("ExpandCommand");
             x.IsExpanded.Value ^= true; // 通知時間表示エリアの表示状態を反転。
        });

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="schedule"></param>
        public ScheduleReminderViewModel(ScheduleReminder schedule)
            : base(schedule)
        {
            // 通知時間リストを表示用の通知時間リストにセットする。
            foreach (int time in schedule.Notifications)
            {
                Notifications.Add(time);
            }
        }
    }
}