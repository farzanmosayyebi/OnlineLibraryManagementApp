using OnlineLibrary.Models.LibraryItems.General;

namespace OnlineLibrary.Models.LibraryItems.AudioBook
{
    internal interface IBorrowableAudioBook : IAudioBook, IBorrowableItem
    {
    }
}
