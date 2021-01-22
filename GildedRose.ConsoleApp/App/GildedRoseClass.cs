using GildedRose.ConsoleApp.Services;
using System.Collections.Generic;

namespace GildedRose.ConsoleApp
{
    public class GildedRoseClass
    {
        public IList<Item> Items { get; set; }
        private readonly AgedBrieService _agedBrieService;
        private readonly BackstageService _backstageService;
        private readonly NormalItemService _normalItemService;
        private readonly ConjuredItemService _conjuredItemService;

        public GildedRoseClass(IList<Item> Items, AgedBrieService agedBrieService, BackstageService backstageService, NormalItemService normalItemService, ConjuredItemService conjuredItemService)
        {
            this.Items = Items;
            _agedBrieService = agedBrieService;
            _backstageService = backstageService;
            _normalItemService = normalItemService;
            _conjuredItemService = conjuredItemService;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                switch(item.Name)
                {
                    case "Aged Brie":
                        _agedBrieService.UpdateQuality(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        _backstageService.UpdateQuality(item);
                        break;
                    case "Conjured Mana Cake":
                        _conjuredItemService.UpdateQuality(item);
                        break;
                    default:
                        _normalItemService.UpdateQuality(item);
                        break;
                }
            }
        }
    }
}
