using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents
{
    public abstract class Bus
    {
        protected string _terminalOne = "N/A";
        protected string _terminalTwo = "N/A";
        protected string _line = "N/A";

        public string TerminalOne { get { return _terminalOne; } set { _terminalOne = value; } }
        public string TerminalTwo { get { return _terminalTwo; } set { _terminalTwo = value; } }

        public string Line { get { return _line; } set { _line = value; } }


        public string Description { get => $"{_line} : {_terminalOne} / {_terminalTwo}"; }

    }
}
