using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySQL.Classes
{
    internal class Loan
    {
        int id;
        string date;
        int customerID;
        int bookID;

        Loan(int cID, int bID)
        {
            date = DateTime.Today.ToShortDateString();
            customerID = cID;
            bookID = bID;
        }
    }
}
