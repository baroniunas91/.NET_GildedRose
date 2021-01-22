using GildedRose.ConsoleApp.Interfaces;
using System.Collections.Generic;

namespace GildedRose.ConsoleApp.Services
{
    public class ThirtyDaysService
    {
        private readonly IPrinter _printService;
        private readonly IDayService _dayService;
        private readonly GildedRoseClass _app;

        public ThirtyDaysService(IPrinter printService, IDayService dayService, GildedRoseClass app)
        {
            _printService = printService;
            _dayService = dayService;
            _app = app;
        }

        public void PrintThirtyDaysItemsResults(IList<Item> Items)
        {
            _printService.Print("OMGHAI!");
            for (var i = 0; i < 31; i++)
            {
                _printService.Print("-------- day " + i + " --------");
                _printService.Print("name, sellIn, quality");
                _dayService.PrintOneDayItemsResults(Items);
                _printService.Print("");
                _app.UpdateQuality();
            }
        }
    }
}
