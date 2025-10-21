using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationHelper
{
    internal class Context
    {
        private string _context;

        public Context()
        {
            this._context = String.Empty;
        }

        public Context(string context )
        {
            this._context = context;
        }

        public string Context_Definition { get { return _context; } }
    }
}
