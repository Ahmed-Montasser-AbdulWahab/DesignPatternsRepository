using IteratorPattern.SystemComponents.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents.Menus
{
    public class CompanyBusesMenu : Menu
    {
        private readonly List<CompanyBus> _companyBuses;

        public CompanyBusesMenu()
        {
            _companyBuses = new List<CompanyBus>();
            AddCompanyBus("Q3", "Obour City", "AbdulMoneim Riyadh", "Engliziyah");
            AddCompanyBus("M5", "Fifth Settlement", "AbdulMoneim Riyadh", "Mwasalat Misr");
            AddCompanyBus("219", "Bashteel", "Salam BusStop", "Nozha");
            AddCompanyBus("106", "Ataba", "Salam BusStop", "Sakr");

            
        }


        private void AddCompanyBus(string line, string terminalOne, string terminalTwo, string company)
        {
            _companyBuses.Add(new CompanyBus(company, line, terminalOne, terminalTwo));
        }

        public override IEnumerator<Bus> GetEnumerator()
        {
            return new CompanyIterator(_companyBuses);
        }



        public override string? this[int index]
        {
            get
            {
                if (index < Filled)
                {
                    return _companyBuses[index]?.Description;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

    }
}
