using OnlineLibrary.Models.LibraryItems.AudioBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Services
{
    public class AudioBookService : IServices<IAudioBook>
    {
        public static List<IAudioBook> items = new List<IAudioBook>();

        public void Add(IAudioBook item)
        {
            if (item is null)
                return;
            items.Add(item);
        }

        public void Remove(string id)
        {
            var item = items.FirstOrDefault(c => c.ItemID == id);
            if (item is null)
                return;
            items.Remove(item);
            Console.WriteLine("Item removed . . .");
        }

        public void Update(IAudioBook item)
        {
            int index = items.FindIndex(c => c.ItemID == item.ItemID);
            if (index == -1)
                return;
            items[index] = item;
        }
    }
}