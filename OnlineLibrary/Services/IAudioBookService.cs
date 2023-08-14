using ExampleLibrary;
using OnlineLibrary.Models.LibraryItems.AudioBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Services
{
    public interface IAudioBookService : IServices<IAudioBook>
    {
        List<IAudioBook> AudioBooks { get; }
    }
}
