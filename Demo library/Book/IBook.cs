using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_library
{
    public interface IBook : ILibraryItem
    {
        int Pages { get; set; }
        string Author { get; set; }
    }
}
