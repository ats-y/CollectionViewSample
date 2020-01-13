using System;
using CollectionViewSample.ViewModels;
using Xamarin.Forms;

namespace CollectionViewSample
{
    public class ScheduleDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ScheduleTemplate { get; set; }
        public DataTemplate SchedulePeriodTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if(item is SchedulePeriodViewModel)
            {
                return SchedulePeriodTemplate;
            }

            return ScheduleTemplate;
        }
    }
}
