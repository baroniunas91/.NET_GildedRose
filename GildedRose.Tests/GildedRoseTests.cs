using FluentAssertions;
using GildedRose.ConsoleApp;
using GildedRose.ConsoleApp.Services;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseTests
    {
        [Theory]
        [InlineData(1, 1, 2, 0)]
        [InlineData(-1, 12, 0, 10)]
        [InlineData(-6, 50, -5, 50)]
        public void TestAgedBrieService(int sellInShouldBe, int qualityShouldBe, int currentSellIn, int currentQuality)
        {
            //Arrange
            var itemService = new ItemService();
            var agedBrieService = new AgedBrieService(itemService);
            Item item = new Item() { Name = "Aged Brie", SellIn = currentSellIn, Quality = currentQuality };
            //Act
            agedBrieService.UpdateQuality(item);
            //Assert
            item.SellIn.Should().Be(sellInShouldBe);
            item.Quality.Should().Be(qualityShouldBe);
        }

        [Theory]
        [InlineData(12, 23, 13, 22)]
        [InlineData(-1, 0, 0, 50)]
        [InlineData(6, 33, 7, 31)]
        [InlineData(1, 47, 2, 44)]
        public void TestBackStageService(int sellInShouldBe, int qualityShouldBe, int currentSellIn, int currentQuality)
        {
            //Arrange
            var itemService = new ItemService();
            var backstageService = new BackstageService(itemService);
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = currentSellIn, Quality = currentQuality };
            //Act
            backstageService.UpdateQuality(item);
            //Assert
            item.SellIn.Should().Be(sellInShouldBe);
            item.Quality.Should().Be(qualityShouldBe);
        }

        [Theory]
        [InlineData(7, 17, 8, 18)]
        [InlineData(-1, 8, 0, 10)]
        [InlineData(-19, 0, -18, 0)]
        public void TestNormalItemService(int sellInShouldBe, int qualityShouldBe, int currentSellIn, int currentQuality)
        {
            //Arrange
            var itemService = new ItemService();
            var normalItemService = new NormalItemService(itemService);
            Item item = new Item() { Name = "+5 Dexterity Vest", SellIn = currentSellIn, Quality = currentQuality };
            //Act
            normalItemService.UpdateQuality(item);
            //Assert
            item.SellIn.Should().Be(sellInShouldBe);
            item.Quality.Should().Be(qualityShouldBe);
        }

        [Theory]
        [InlineData(0, 2, 1, 4)]
        [InlineData(-2, 6, -1, 10)]
        [InlineData(-8, 0, -7, 0)]
        public void TestConjuredItemService(int sellInShouldBe, int qualityShouldBe, int currentSellIn, int currentQuality)
        {
            //Arrange
            var itemService = new ItemService();
            var conjuredItemService = new ConjuredItemService(itemService);
            Item item = new Item() { Name = "Conjured Mana Cake", SellIn = currentSellIn, Quality = currentQuality };
            //Act
            conjuredItemService.UpdateQuality(item);
            //Assert
            item.SellIn.Should().Be(sellInShouldBe);
            item.Quality.Should().Be(qualityShouldBe);
        }

        [Theory]
        [InlineData(0, 80, 0, 80)]
        [InlineData(-1, 80, -1, 80)]
        public void TestSulfurasItem(int sellInShouldBe, int qualityShouldBe, int currentSellIn, int currentQuality)
        {
            //Arrange
            var itemService = new ItemService();
            var agedBrieService = new AgedBrieService(itemService);
            var backstageService = new BackstageService(itemService);
            var normalItemService = new NormalItemService(itemService);
            var conjuredItemService = new ConjuredItemService(itemService);
            IList<Item> Items = new List<Item>{
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = currentSellIn, Quality = currentQuality},
            };
            var app = new GildedRoseClass(Items, agedBrieService, backstageService, normalItemService, conjuredItemService);
            //Act
            app.UpdateQuality();
            //Assert
            Items[0].SellIn.Should().Be(sellInShouldBe);
            Items[0].Quality.Should().Be(qualityShouldBe);
        }
    }
}
