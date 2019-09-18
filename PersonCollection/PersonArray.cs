using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollection
{
    class PersonArray :  IEnumerable
    {
        private ArrayList pArray = new ArrayList();
        public void AddPerson(Person p)
        {
            pArray.Add(p);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)pArray).GetEnumerator();
        }

        public int PersonCount => pArray.Count;

        
    }
}
