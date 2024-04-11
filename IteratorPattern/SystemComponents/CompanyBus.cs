
using System.Text.RegularExpressions;


namespace IteratorPattern.SystemComponents
{
    public class CompanyBus : Bus
    {
        private string _company = "N/A";

        public CompanyBus(string company, string line, string terminalOne, string terminalTwo)
        {
            if (Regex.IsMatch(line, "^[A-Z]?[0-9]*$"))
            {
                _terminalOne = terminalOne;
                _terminalTwo = terminalTwo;
                _line = line;
                _company = company;
            }
            else
            {
                _terminalOne = _terminalTwo = _line = _company = "N/A";
            }
        }

        public string Company {  get { return _company; } set { _company = value; } }
    }
}
