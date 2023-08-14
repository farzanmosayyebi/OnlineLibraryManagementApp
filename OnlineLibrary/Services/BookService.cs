using OnlineLibrary.Models.LibraryItems.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Services
{
    public class BookService : IServices<IBook>
    {
        public static List<IBook> items = new List<IBook>();

        public void Add(IBook item)
        {
            if (item is null || items.Contains(item))
                return;

            items.Add(item);
        }

        public void Update(IBook item)
        {
            int index = items.FindIndex(c => c.ItemID == item.ItemID);
            if (index == -1)
                return;
            items[index] = item;
        }

        public void Remove(string id)
        {
            var item = items.FirstOrDefault(c => c.ItemID == id);

            if (item is null)
                return;
            items.Remove(item);
            Console.WriteLine("Item Removed . . .");
        }
    }
}
