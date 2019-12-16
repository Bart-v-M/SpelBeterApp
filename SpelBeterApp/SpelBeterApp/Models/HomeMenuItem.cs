using System;
using System.Collections.Generic;
using System.Text;

namespace SpelBeterApp.Models
{
    public enum MenuItemType
    {
        Calendar,
        Settings,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
