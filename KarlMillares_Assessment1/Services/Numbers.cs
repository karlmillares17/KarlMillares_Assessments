using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares_Assessment1.Services
{
    public class Numbers : INumbers
    {
        private List<int> _inputList;
        private List<int> _sorted;
        private List<int> _unsorted;

        public List<int> InputList { get { return _inputList; } }
        public List<int> Sorted { get { return _sorted; } }
        public List<int> Unsorted { get { return _unsorted; } }

        public Numbers(int removedNumber)
        {
            if (removedNumber < 1 || removedNumber > 100)
                throw new Exception("Incorrect input");

            _inputList = Enumerable.Range(1, 100).Where(x => !x.Equals(removedNumber)).ToList();
            _sorted = Enumerable.Range(1, 100).ToList();
            _unsorted = _sorted.OrderBy(x => new Random().Next()).ToList();
        }

        public int GetRemovedNumberInSorted()
        {
            return _sorted.Except(_inputList).SingleOrDefault();
        }
        public int GetRemovedNumberInUnsorted()
        {
            return _unsorted.Except(_inputList).SingleOrDefault();
        }
    }
}
