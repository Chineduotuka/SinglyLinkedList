using System;
using System.Collections;
using System.Collections.Generic;

namespace CoustomLinkedList
{
    public class Node<T>
    {
        // creating a property called data
        public T Data { get; set; }

        //creating a property of pointer pointing to the next address
        //remove or make it internal the setter, to restrict access of seting t values
        public Node<T> Next { get; internal set; }
        
    }
    public class LinkedLis <T> : IEnumerable<T>
    {
        //properties
        //for a pointer to the first 
        public Node <T> Head { get; private set; }

        public Node <T> Tail { get; private set; }  

        //count to know how many items are in the linked list
        public int Count { get; private set; }


        public LinkedLis()
        {
            Head = null;
            Tail = null;
        }
        
        //add to the top of the stack 
        public int AddFirst(T newNode)
        {
            var NewNode = new Node<T> { Data = newNode };
            if(Head == null)
            {
                //this means the linkwed list is empty
                //insert the new node on point the head and tail to the node
                Head = NewNode;
                Tail = NewNode;
            }
            else
            {
                NewNode.Next = Head;
                Head = NewNode;
            }
            Count++;

            return Count;
        }
        //add to the tail of the stack
        public void Add(T newNode)
        {
            Node<T> NewNode = new Node<T> { Data = newNode };
            if(Tail == null)
            {
                Head= NewNode;
                Tail = NewNode;
            }
            else
            {
                Tail.Next = NewNode;
                Tail = NewNode;
            }
            Count++;
        }

        //check for the existance of the target data in the list
        public bool Checks( T target)
        {
            Node<T> CurrentNode = Head;

            while(CurrentNode != null && !CurrentNode.Data.Equals(target))
            {
                CurrentNode = CurrentNode.Next;
            }
            if(CurrentNode != null && CurrentNode.Data.Equals(target))
            {
                return true;
            }
            return false;
        }

        //check the index of a target data in the liost
        public int Indexer(T target)
        {
            int Index = 1;

            Node<T> CurrentNode = Head;
            while (CurrentNode != null && !CurrentNode.Data.Equals(target))
            {
                CurrentNode = CurrentNode.Next;
                Index++;
            }
            if(CurrentNode == null)
            {
                return -1;
            }
            return Index;   
        }
        //return the last item in the list
        public T LastItem()
        {
            Node<T> Previous = Head;
            Node<T> Current = Tail; 

            return Previous.Data;
        }

        //remove the and return the first element in the stack
        public T RemoveFirst()
        {
            Node<T> reviewe = Head;
            if(Head == null || Count == 0)
            {
                throw new InvalidOperationException("Item is empty");
            }
            else
            {
                Head = Head.Next;
                Count--;      
            }
            return reviewe.Data;
        }

        //does the same thing as the RemoveFirst but returns void
        public void RemoveFirstInStack()
        {
            if (Head == null || Count == 0)
            {
                throw new InvalidOperationException("Item is empty");
            }
            else
            {
                Head = Head.Next;
                Count--;
            }
        }
        public void RemoveLast()
        {
            
            //Node<T> LastNode = Last;
            Node<T> CurrentNode = Head;
            if(Count!=0)
            {
                if (Count == 1)
                {
                    Tail = null;
                    Head = null;
                }
                else
                {

                    while (CurrentNode.Next != Tail)
                    {
                        //LastNode = CurrentNode;
                        CurrentNode = CurrentNode.Next;
                    }
                    CurrentNode.Next = null;
                    Tail = CurrentNode;
                }
                Count--;
            }

        }

        //remove a target elemnt and return a bool
        public bool Remove(T target)
        {
            Node<T> previous = null;
            Node<T> CurrentNode = Head;    
          
            while(CurrentNode != null)
            {
                if(CurrentNode.Data.Equals(target))
                {
                    if(previous != null)
                    {
                        previous.Next = CurrentNode.Next;

                        if(CurrentNode.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirstInStack();
                    }
                    return true;
                }
                
                previous = CurrentNode;
                CurrentNode = CurrentNode.Next;

            }
            return false;
        }

        //enables the ability to print using for each
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while(current.Next != null )
            {
                yield return current.Data;
                current = current.Next;
            }
            yield return current.Data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
