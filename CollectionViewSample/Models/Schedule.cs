using System;
namespace CollectionViewSample.Models
{
    /// <summary>
    /// 通常スケジュール
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// 開始日時
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }

        public Schedule()
        {
        }
    }
}
