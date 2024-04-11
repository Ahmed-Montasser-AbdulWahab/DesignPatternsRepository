using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents
{
    public class CTABus : Bus
    {
        public CTABus(string line, string terminalOne, string terminalTwo)
        {
            if (Regex.IsMatch(line, "^[A-Z]?[0-9]*$")) {
                _terminalOne = terminalOne;
                _terminalTwo = terminalTwo;
                _line = line;
            } else
            {
                _terminalOne = _terminalTwo = _line = "N/A";
            }
        }
    }
}
