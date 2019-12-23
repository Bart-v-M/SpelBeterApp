using System;

using SpelBeterApp.Models;

namespace SpelBeterApp.ViewModels
{
    public class CalendarDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public CalendarDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
