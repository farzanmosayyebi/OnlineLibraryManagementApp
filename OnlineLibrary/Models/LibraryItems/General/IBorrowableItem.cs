using OnlineLibrary.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.General
{
    public interface IBorrowableItem : ILibraryItem
    {
        int CheckOutDurationInDays { get; set; }
        DateTime BorrowDate { get; set; }
        Member Borrower { get; set; }

        void CheckOut(Member borrower);
        void CheckIn();
        DateTime GetDueDate();
    }
}
