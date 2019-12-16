using System;

using SpelBeterApp.Models;

namespace SpelBeterApp.ViewModels
{
    public class CalenderDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public CalenderDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
