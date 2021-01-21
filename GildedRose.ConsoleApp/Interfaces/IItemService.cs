using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ConsoleApp.Interfaces
{
    public interface IItemService
    {
        IList<Item> CreateItems();
    }
}
