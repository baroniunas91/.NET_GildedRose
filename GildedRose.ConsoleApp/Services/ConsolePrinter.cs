using GildedRose.ConsoleApp.Interfaces;
using System;

namespace GildedRose.ConsoleApp.Services
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
