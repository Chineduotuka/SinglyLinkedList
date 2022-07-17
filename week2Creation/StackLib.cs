using System;
using System.Collections;
using System.Collections.Generic;
using CoustomLinkedList;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2Creation
{
    public class StackLib<T> : IEnumerable<T>
    {
        LinkedLis<T> StackItem = new LinkedLis<T>();



        public int StackSize { get; private set; }

        //push to adds to the top of the stack
        public void StackPush(T Item)
        {
            StackItem.AddFirst(Item);
            StackSize++; 
        }

        //removes from the tail of the stack
        public T StackPop()
        {
            StackSize--;
            return StackItem.RemoveFirst();
        }

        //peek returns the last element added to the stack
        public T StackPeek()
        {
            return StackItem.LastItem();
        }

        //checks if the stack is empty
        public bool StackIsEmpty()
        {
            if (StackSize == 0)
            {
                return true;
            }
            return false;
        }

        //returns the size of the array
        public int StackArraySize()
        {
            return StackItem.Count();
        }
        public IEnumerator<T> GetEnumerator()
        {
          
            foreach(T Item in StackItem)
            {
                yield return Item;
            }
           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
