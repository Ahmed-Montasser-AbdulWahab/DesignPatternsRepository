using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents.Iterators
{
    public class CompanyIterator : IEnumerator<Bus>
    {
        private int _position = -1;
        private Bus _curBus;
        private readonly List<CompanyBus> _companyBuses;

        public CompanyIterator(List<CompanyBus> companyBuses)
        {
            _companyBuses = companyBuses;
            _position = -1;
            _curBus = default(CompanyBus);
        }

        public Bus Current => _curBus;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++_position < _companyBuses.Count)
            {
                _curBus = _companyBuses[_position];
                return true;
            }
            else
            {
                return false;

            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
