using OnlineLibrary.Models.LibraryItems.General;

namespace OnlineLibrary.Models.LibraryItems.Book
{
    internal interface IBorrowableBook : IBook, IBorrowableItem
    {
    }
}
