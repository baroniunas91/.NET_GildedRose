using GildedRose.ConsoleApp.Interfaces;

namespace GildedRose.ConsoleApp.Services
{
    public class ConjuredItemService
    {
        private readonly IItemService _itemService;

        public ConjuredItemService(IItemService itemService)
        {
            _itemService = itemService;
        }

        public void UpdateQuality(Item item)
        {
            //Conjured item
            if (item.Quality > 0)
            {
                _itemService.ReduceQualityTwice(item);
                if (item.SellIn <= 0 && item.Quality != 0)
                {
                    _itemService.ReduceQualityTwice(item);
                }
                _itemService.ReduceSellIn(item);
            }
            else if (item.Quality <= 0)
            {
                _itemService.ReduceSellIn(item);
            }
        }
    }
}
