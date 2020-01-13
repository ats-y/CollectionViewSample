using System;
namespace CollectionViewSample.Models
{
    /// <summary>
    /// 期間スケジュール
    /// </summary>
    public class SchedulePeriod : Schedule
    {
        /// <summary>
        /// 予定終了日時
        /// </summary>
        public DateTime PeriodTo { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 場所
        /// </summary>
        public string Place { get; set; }

        public SchedulePeriod()
        {
        }
    }
}
