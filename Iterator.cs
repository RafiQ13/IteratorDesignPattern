using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class Iterator : AbstractIterator
    {
        //ConcreteAggregate variable to hold the collection elements
        private ConcreteCollection Collection;
        
        
        //The following variable is used as the Index Position 
        //to access the elements of the collection
        private int Current = 0;

        //The following variable is used to move to the next element from the current element
        private readonly int Step = 1;
        // Constructor
        public Iterator(ConcreteCollection Collection)
        {
            //Initializing the ConcreteAggregate variable using Constructor
            this.Collection = Collection;
        }


        public bool IsCompleted() {

            //When Current >= Collection.Count, means we have accessed all the elements
            return Current >= Collection.Count;
        }
        public Student First()
        {
            Current = 0;
            return Collection.GetStudent(Current);
        }

        public Student Next()
        {
            //Increase the Current Index Position by step (Step = 1), 
            //to access the Next Element from the collection
            Current += Step;
            if (!IsCompleted())
            {
                return Collection.GetStudent(Current);
            }
            else
            {
                throw new InvalidOperationException("Iterator is completed.");
            }
        }
    }
}
