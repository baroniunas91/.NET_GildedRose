using System.Collections.Generic;

namespace GildedRose.ConsoleApp.Interfaces
{
    public interface IDayService
    {
        void PrintOneDayItemsResults(IList<Item> Items);
    }
}
