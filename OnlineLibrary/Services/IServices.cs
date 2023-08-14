using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Services
{
    public interface IServices<T>
    {
        static List<T> items { get; }
        void Add(T item);
        void Update(T item);
        void Remove(string id);
    }
}
