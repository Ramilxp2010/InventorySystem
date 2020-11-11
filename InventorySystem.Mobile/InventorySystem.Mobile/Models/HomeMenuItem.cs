using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Mobile.Models
{
    public enum MenuItemType
    {
        Warehouse,
        Purchase,
        Invoice,
        Inventory,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
