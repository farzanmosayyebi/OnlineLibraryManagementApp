using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.General
{
    public class LibraryItem : ILibraryItem
    {
        public string Title { get; set; }
        public string ItemID { get; set; }
        public string LibraryID { get; set; }
        public string Description { get; set; }
    }
}
