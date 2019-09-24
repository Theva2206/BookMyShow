using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyShow.Models
{
    public class Customer : IEnumerable
    {
        private int _custId;
        private string _custName;

        public int CustID
        {
            get { return _custId; }
            set { _custId = value; }
        }

        public string CustName
        {
            get { return _custName; }
            set { _custName = value; }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}