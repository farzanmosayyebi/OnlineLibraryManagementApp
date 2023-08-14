using OnlineLibrary.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.DVD
{
    public class BorrowableDVD : IBorrowableDVD
    {
        public string Title { get; set; }
        public string ItemID { get; set; }
        public string LibraryID { get; set; }
        public string Description { get; set; }
        public int RunTimeInMinutes { get; set; }
        public int CheckOutDurationInDays { get; set; }
        public DateTime BorrowDate { get; set; }
        public Member Borrower { get; set; }

        public void CheckOut(Member borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
            CheckOutDurationInDays = 14;
        }
        public void CheckIn()
        {
            Borrower = null;
        }
        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }

    }
}
