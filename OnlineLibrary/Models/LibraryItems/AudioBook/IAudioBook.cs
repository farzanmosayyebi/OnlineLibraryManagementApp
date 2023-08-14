using OnlineLibrary.Models.LibraryItems.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.LibraryItems.AudioBook
{
    public interface IAudioBook : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }
        string[] Narrators { get; set; }
    }
}