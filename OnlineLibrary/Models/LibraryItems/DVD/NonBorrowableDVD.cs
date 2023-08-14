using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.DVD
{
    public class NonBorrowableDVD : IDVD
    {
        public int RunTimeInMinutes { get; set; }
        public string Title { get; set; }
        public string ItemID { get; set; }
        public string LibraryID { get; set; }
        public string Description { get; set; }
    }
}
