using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Models.LibraryItems.General;

namespace OnlineLibrary.Services
{
    public class LibraryItemService : IServices<ILibraryItem>
    {
        public List<ILibraryItem> items = new List<ILibraryItem>();

        public void Add(ILibraryItem item)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(ILibraryItem item)
        {
            throw new NotImplementedException();
        }
    }
}
