using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents.Menus
{
    public abstract class Menu : IEnumerable<Bus>
    {
        protected int filled = 0;
        public abstract IEnumerator<Bus> GetEnumerator();
        public int Filled { get { return filled; } }

        public abstract string? this[int index]
        {
            get;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
