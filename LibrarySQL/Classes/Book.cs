using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySQL.Classes
{
    internal class Book
    {
        int id;
        string title = "";
        string author = "";

        Book(string t, string a)
        {
            title = t;
            author = a;
        }
    }
}
