using GildedRose.ConsoleApp;
using System;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseTests
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
            };
            GildedRoseClass app = new GildedRoseClass(Items);
            app.UpdateQuality();
            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);
        }
    }
}
