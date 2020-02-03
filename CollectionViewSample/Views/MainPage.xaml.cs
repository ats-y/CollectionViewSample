using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewSample.ViewModels;
using Xamarin.Forms;

namespace CollectionViewSample.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel ViewModel { get => BindingContext as MainPageViewModel; }

        public MainPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw ex;
            }
        }

        public void OnClickedTest(object sender, EventArgs args)
        {
            ViewModel.ShowSchedule();

            //if (ScheduleCollectionView.ItemSizingStrategy == ItemSizingStrategy.MeasureFirstItem)
            //{
            //    ScheduleCollectionView.ItemSizingStrategy = ItemSizingStrategy.MeasureAllItems;
            //}
            //else
            //{
            //    ScheduleCollectionView.ItemSizingStrategy = ItemSizingStrategy.MeasureFirstItem;
            //}
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //ViewModel.ShowSchedule();
        }
    }
}
