using GildedRose.ConsoleApp.Services;
using System;
using System.Collections.Generic;

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
            //Get all items
            var items = itemService.CreateItems();
            //Create app with all business logic
            var app = new GildedRoseClass(items);
            //Print all 30 days results
            var thirtyDaysService = new ThirtyDaysService(printService, dayService, app);
            thirtyDaysService.PrintThirtyDaysItemsResults(items);
        }
    }
}