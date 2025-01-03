using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_11_HW
{
    internal class InvalidProductException : Exception
    {
        public InvalidProductException(string message) : base(message) { }
    }
}
