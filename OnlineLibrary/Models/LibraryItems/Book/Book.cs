using OnlineLibrary.Models.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.Book
{
    public class Book : IBorrowableBook
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public string LibraryID { get; set; }
        public string ItemID { get; set; }
        public int CheckOutDurationInDays { get; set; }
        public Member Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

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
