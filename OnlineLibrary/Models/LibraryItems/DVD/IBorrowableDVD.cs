using OnlineLibrary.Models.LibraryItems.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.DVD
{
    public interface IBorrowableDVD : IDVD, IBorrowableItem
    {
    }
}
