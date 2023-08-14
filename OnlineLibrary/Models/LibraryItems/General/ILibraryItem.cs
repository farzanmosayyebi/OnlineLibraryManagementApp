namespace OnlineLibrary.Models.LibraryItems.General
{
    public interface ILibraryItem
    {
        string Title { get; set; }
        string ItemID { get; set; }
        string LibraryID { get; set; }
        string Description { get; set; }
    }
}
