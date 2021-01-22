using GildedRose.ConsoleApp.Interfaces;

namespace GildedRose.ConsoleApp.Services
{
    public class AgedBrieService
    {
        private readonly IItemService _itemService;

        public AgedBrieService(IItemService itemService)
        {
            _itemService = itemService;
        }

        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                _itemService.IncreaseQuality(item);
                if (item.SellIn <= 0 && item.Quality < 50)
                {
                    _itemService.IncreaseQuality(item);
                }
                _itemService.ReduceSellIn(item);
            }
            else if (item.Quality == 50)
            {
                _itemService.ReduceSellIn(item);
            }
        }
    }
}
