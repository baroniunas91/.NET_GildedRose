using GildedRose.ConsoleApp.Interfaces;

namespace GildedRose.ConsoleApp.Services
{
    public class BackstageService
    {
        private readonly IItemService _itemService;

        public BackstageService(IItemService itemService)
        {
            _itemService = itemService;
        }

        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                _itemService.IncreaseQuality(item);
                if (item.SellIn < 11 && item.Quality < 50)
                {
                    _itemService.IncreaseQuality(item);
                }

                if (item.SellIn < 6 && item.Quality < 50)
                {
                    _itemService.IncreaseQuality(item);
                }
                _itemService.ReduceSellIn(item);
                if (item.SellIn < 0)
                {
                    _itemService.ZeroQuality(item);
                }
            }
            else if (item.Quality == 50)
            {
                _itemService.ReduceSellIn(item);
                if (item.SellIn < 0)
                {
                    _itemService.ZeroQuality(item);
                }
            }
        }
    }
}
