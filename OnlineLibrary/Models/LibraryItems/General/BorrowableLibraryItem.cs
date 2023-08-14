using OnlineLibrary.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.General
{
    public class BorrowableLibraryItem : LibraryItem, IBorrowableItem
    {
        public int CheckOutDurationInDays { get; set; }
        public DateTime BorrowDate { get; set; }
        public Member Borrower { get; set; }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(Member borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
