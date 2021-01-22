using System.Collections.Generic;

namespace GildedRose.ConsoleApp.Interfaces
{
    public interface IItemService
    {
        IList<Item> CreateItems();
        void ReduceSellIn(Item item);
        void ReduceQuality(Item item);
        void IncreaseQuality(Item item);
        void ZeroQuality(Item item);
        void ReduceQualityTwice(Item item);
    }
}
