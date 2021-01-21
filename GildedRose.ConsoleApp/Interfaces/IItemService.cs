using System.Collections.Generic;

namespace GildedRose.ConsoleApp.Interfaces
{
    public interface IItemService
    {
        IList<Item> CreateItems();
    }
}
