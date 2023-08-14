using OnlineLibrary.Models.LibraryItems.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.Book
{
    public interface IBook : ILibraryItem
    {
        public int NumberOfPages { get; set; }
        public string Author { get; set; }
    }
}
