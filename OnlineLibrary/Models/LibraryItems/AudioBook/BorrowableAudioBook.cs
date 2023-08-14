using OnlineLibrary.Models.People;
using System.Collections.Generic;

namespace OnlineLibrary.Models.LibraryItems.AudioBook
{
    public class BorrowableAudioBook : IBorrowableAudioBook
    {
        public string Title { get; set; }
        public string ItemID { get; set; }
        public string LibraryID { get; set; }
        public string Description { get; set; }
        public int RunTimeInMinutes { get; set; }
        public string[] Narrators { get; set; }
        public int CheckOutDurationInDays { get; set; }
        public DateTime BorrowDate { get; set; }
        public Member Borrower { get; set; }

        public void CheckIn()
        {
            Borrower = null;
        }

        public void CheckOut(Member borrower)
        {
            CheckOutDurationInDays = 14;
            Borrower = borrower;
            Console.WriteLine($"New Borrower: {Borrower.FirstName} {Borrower.LastName}");
            BorrowDate = DateTime.Now; ;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
