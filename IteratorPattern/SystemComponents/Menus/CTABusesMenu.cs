using IteratorPattern.SystemComponents.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents.Menus
{
    public class CTABusesMenu : Menu
    {
        private readonly CTABus[] ctaBuses;
        private const int NUMBER_OF_BUSES = 10;
        

        public CTABusesMenu()
        {
            ctaBuses = new CTABus[NUMBER_OF_BUSES];
            AddCTABus("1001", "First Settlement", "AbdulMoneim Riyadh");
            AddCTABus("1002", "Masakn Ain Shams", "Matbaa");
            AddCTABus("1003", "Cairo Airport", "Bolak Dakroor");
            AddCTABus("1004", "Salam City", "Ataba");
            



        }

        private void AddCTABus (string line, string terminalOne, string terminalTwo)
        {
            if (filled < NUMBER_OF_BUSES) { ctaBuses[filled++] = new CTABus(line, terminalOne, terminalTwo); }
            else { throw new IndexOutOfRangeException("Menu is filled"); } 
        }

        public override IEnumerator<Bus> GetEnumerator()
        {
            return new CtaIterator(ctaBuses);
        }


        public int Filled { get { return filled; } }

        public override string? this[int index] { get {
                if(index < NUMBER_OF_BUSES)
                {
                    return ctaBuses[index]?.Description;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            } }

    }
}
