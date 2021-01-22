using GildedRose.ConsoleApp.Services;

namespace GildedRose.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize required services
            var printService = new ConsolePrinter();
            var itemService = new ItemService();
            var dayService = new DayService(printService);
            var agedBrieService = new AgedBrieService(itemService);
            var backstageService = new BackstageService(itemService);
            var normalItemService = new NormalItemService(itemService);
            var conjuredItemService = new ConjuredItemService(itemService);
            //Get all items
            var items = itemService.CreateItems();
            //Create app with all business logic
            var app = new GildedRoseClass(items, agedBrieService, backstageService, normalItemService, conjuredItemService);
            //Print all 30 days results
            var thirtyDaysService = new ThirtyDaysService(printService, dayService, app);
            thirtyDaysService.PrintThirtyDaysItemsResults(items);
        }
    }
}