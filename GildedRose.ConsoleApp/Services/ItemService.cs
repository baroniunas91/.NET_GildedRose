using GildedRose.ConsoleApp.Interfaces;
using System.Collections.Generic;

namespace GildedRose.ConsoleApp.Services
{
    public class ItemService : IItemService
    {
        public IList<Item> CreateItems()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            return Items;
        }

        public void ReduceSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        public void ReduceQuality(Item item)
        {
            item.Quality -= 1;
        }

        public void IncreaseQuality(Item item)
        {
            item.Quality += 1;
        }

        public void ZeroQuality(Item item)
        {
            item.Quality = 0;
        }

        public void ReduceQualityTwice(Item item)
        {
            item.Quality -= 2;
        }
    }
}
