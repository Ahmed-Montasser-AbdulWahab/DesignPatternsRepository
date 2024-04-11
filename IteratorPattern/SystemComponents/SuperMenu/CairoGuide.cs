using IteratorPattern.SystemComponents.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents.SuperMenu
{
    public class CairoGuide
    {
        private Menu[] _menus;
        public CairoGuide(params Menu[] menus) { _menus = menus;  }

        public void printLines()
        {
            if (_menus is null || _menus.Length == 0) { Console.WriteLine("Empty"); }
            else
            {
                Console.WriteLine("Start");
                foreach (Menu menu in _menus)
                {
                    printLines(menu.GetEnumerator());
                }
                Console.WriteLine("End");
            }

        }

        private void printLines(IEnumerator<Bus> enumerator)
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Description);
            }
            enumerator.Reset();
        }
    }
}
