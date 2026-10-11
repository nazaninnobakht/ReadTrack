using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTrack.Console;
public class Book
{
    public string Title { get; set; } = string.Empty;
    public int PageCount { get; set; }
    public int CurrentPage { get; set; }
}
