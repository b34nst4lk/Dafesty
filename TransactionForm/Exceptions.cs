using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionForm
{
    public class ItemNotFound: ApplicationException
    {
        public ItemNotFound() { }
        public ItemNotFound(string msg) : base(msg) { }
    }

    public class InvalidID: ApplicationException
    {
        public InvalidID() { }
        public InvalidID(string msg) : base(msg) { }
    }
}
