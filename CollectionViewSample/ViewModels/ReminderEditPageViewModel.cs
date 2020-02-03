using System;
using Prism.Navigation;
using Xamarin.Forms;

namespace CollectionViewSample.ViewModels
{
    /// <summary>
    /// リマインダー編集画面ViewModel
    /// </summary>
    public class ReminderEditPageViewModel
    {
        /// <summary>
        /// 閉じるコマンド
        /// </summary>
        public Command CancelCommand { get;  }

        private INavigationService _navigationService;

        public ReminderEditPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            CancelCommand = new Command(async () =>
            {
                await _navigationService.GoBackAsync(useModalNavigation: true);
            });
        }
    }
}
