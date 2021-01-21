using GildedRose.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ConsoleApp.Services
{
    public class DayService : IDayService
    {
        private readonly IPrinter _printService;
        public DayService(IPrinter printService)
        {
            _printService = printService;
        }
        public void PrintOneDayItemsResults(IList<Item> Items)
        {
            foreach (Item item in Items)
            {
                _printService.Print(item.Name + ", " + item.SellIn + ", " + item.Quality);
            }
        }
    }
}