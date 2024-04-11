using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.SystemComponents.Iterators
{
    public class CtaIterator : IEnumerator<Bus>
    {
        private readonly Bus[] _ctaBuses;
        private int _position = -1;
        private Bus _curBus;

        public CtaIterator(CTABus[] ctaBuses)
        {
            _ctaBuses = ctaBuses;
            _position = -1;
            _curBus = default(CTABus);


        }

        public Bus Current => _curBus;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if ( ++_position < _ctaBuses.Length )
            {
                if (_ctaBuses[_position] is not null)
                {
                    _curBus = _ctaBuses[_position];
                    return true;
                }
                return false;
            }
            else
            {
                return false;

            }
        }

        public void Reset()
        {
            _position = -1;
            _curBus = default(CTABus);
        }
    }
}
