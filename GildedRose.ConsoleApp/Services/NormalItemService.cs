using GildedRose.ConsoleApp.Interfaces;

namespace GildedRose.ConsoleApp.Services
{
    public class NormalItemService
    {
        private readonly IItemService _itemService;

        public NormalItemService(IItemService itemService)
        {
            _itemService = itemService;
        }

        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                _itemService.ReduceQuality(item);
                if (item.SellIn <= 0 && item.Quality != 0)
                {
                    _itemService.ReduceQuality(item);
                }
                _itemService.ReduceSellIn(item);
            }
            else if (item.Quality <= 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                _itemService.ReduceSellIn(item);
            }
        }
    }
}
