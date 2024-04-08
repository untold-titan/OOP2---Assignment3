using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface ILinkedListADT
    {
        /// <summary>
        /// Checks if the list is empty.
        /// </summary>
        /// <returns>True if it is empty.</returns>
        bool IsEmpty();

        /// <summary>
        /// Clears the list.
        /// </summary>
        public void RemoveList()
        {

            if (First == null || this.Count == 0)
            {
                //Nothing to do 
                return;
            }
            while (this.First != null)
            {
                this.RemoveFirst();

            }
            return;

        }
        /// <summary>
        /// Adds to the end of the list.

        public void AddLast(Node<T> newNode)
        {
            if (this.Last == null)
            { //This means the lilnked list is empty 
                this.First = newNode;
                this.Last = newNode;

            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;

        }
        
        public void AddFirst(Node<T> newNode)
        {
            if (this.First == null)
            {
                // this measn the linkedlist is empty 

                //insert the new node on point the  head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }
        public void AddAfter(Node<T> newNode, Node<T> oldNode)
        {
            if (this.Last == oldNode)
            {
                Last = newNode;

            }
            newNode.Next = oldNode.Next;
            oldNode.Next = newNode;
            this.Count++;
        }
        
        /// <summary>
        /// Adds a new element at a specific position.
        /// </summary>
        /// <param name="value">Value that element is to contain.</param>
        /// <param name="index">Index to add new element at.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or past the size of the list.</exception>
        void Add(User value, int index);

        /// <summary>
        /// Replaces the value  at index.
        /// </summary>
        /// <param name="value">Value to replace.</param>
        /// <param name="index">Index of element to replace.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        void Replace(User value, int index);

        /// <summary>
        /// Gets the number of elements in the list.
        /// </summary>
        /// <returns>Size of list (0 meaning empty)</returns>
        int Count();

        /// <summary>
        /// Removes first element from list
        /// </summary>
        /// <exception cref="CannotRemoveException">Thrown if list is empty.</exception>
        public void RemoveFirst()
        {
            if (First == null || this.Count == 0)
            {
                return;
            }
            First = First.Next;
            this.Count--;
        }

        /// <summary>
        /// Removes last element from list
        /// </summary>
        /// <exception cref="CannotRemoveException">Thrown if list is empty.</exception>
        public void RemoveLast()
        {
            if (Last == null || this.Count == 0)
            {
                return;
            }
            Last = Last.Next;
            Last.Next = null;
            this.Count--;
        }

        /// <summary>
        /// Removes element at index from list, reducing the size.
        /// </summary>
        /// <param name="index">Index of element to remove.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        public void Remove(Node<T> HollowedNode)
        {
          
            if (First == null || this.Count == 0)
            {
              
                return;
            }
            if (this.First == HollowedNode)
            {
                this.RemoveFirst();
                return;
            }

            Node<T> past = First;
            Node<T> current = past.Next;

            while (current != null && current != HollowedNode)
            {
                //move to next node 
                past = current;
                current = past.Next;
            }

            //Remove it 
            if (current != null)
            {
                past.Next = current.Next;
                this.Count--;
            }

        }

        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">Index of element to get.</param>
        /// <returns>Value of node at index</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        User GetValue(int index);

        /// <summary>
        /// Gets the first index of element containing value.
        /// </summary>
        /// <param name="value">Value to find index of.</param>
        /// <returns>First of index of node with matching value or -1 if not found.</returns>
        int IndexOf(User value);

        /// <summary>
        /// Go through nodes and check if one has value.
        /// </summary>
        /// <param name="value">Value to find index of.</param>
        /// <returns>True if element exists with value.</returns>
        bool Contains(User value);
        public Node<T> Find(T target)
        {
            Node<T> currentNode = First;

            while (currentNode != null && !currentNode.Data.Equals(target))
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }
    }
}
