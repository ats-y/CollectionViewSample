﻿using System;
using CollectionViewSample.ViewModels;
using Xamarin.Forms;

namespace CollectionViewSample
{
    /// <summary>
    /// スケジュール項目表示用DataTemplateのセレクタ。
    /// </summary>
    public class ScheduleDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ScheduleTemplate { get; set; }
        public DataTemplate SchedulePeriodTemplate { get; set; }
        public DataTemplate ScheduleReminderTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is SchedulePeriodViewModel)
            {
                return SchedulePeriodTemplate;
            }
            else if (item is ScheduleReminderViewModel)
            {
                return ScheduleReminderTemplate;
            }
            else
            {
                return ScheduleTemplate;
            }
        }
    }
}
