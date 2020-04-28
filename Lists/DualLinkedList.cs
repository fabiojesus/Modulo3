using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Lists
{
    #region int node
    /// <summary>
    /// A Dual linked node
    /// </summary>
    public class DualLinkedNode<T>
    {
        /// <summary>
        /// The node's content
        /// </summary>
        public T Content { get; set; }
        
        /// <summary>
        /// Next node
        /// </summary>
        public DualLinkedNode<T> Next { get; set; }
        
        /// <summary>
        /// Previous node
        /// </summary>
        public DualLinkedNode<T> Previous { get; set; }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
#endregion 
   
    /// <summary>
    /// A dual linked integer list
    /// </summary>
    public class DualLinkedList<T>
    {
        public DualLinkedNode<T> First { get; set; }

        public T this[int index]
        {
            get
            {
                //Error if the index does not exist in the list
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
                //Starts with the first value
                var current = First;
                //As long has it's not the right index;
                for(var i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                //Returns only the content and not the node itself.
                return current.Content;
            }
        }

        public DualLinkedNode<T> Last { 
            get 
            {
                var current = First;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                return current;
            } 
        }

        public int Count
        {
            get
            {
                var count = 0;
                var current = First;
                while(current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public void AddFirst(T value)
        {
            Add(null, value);
        }

        public void AddLast(T value)
        {
            Add(Last, value);
        }

        public void Add(DualLinkedNode<T> previous, T value)
        {
            var node = new DualLinkedNode<T>() { Content = value };
            //if the first node does not exist, it is filled
            if (First == null)
            {
                First = node;
                return;
            }

            if(previous == null)
            {
                //Changes the node's next pointer to the first node
                node.Next = First;
                //changes t
                First.Previous = node;
                First = node;
            }
            else
            {
                var next = previous.Next;
                node.Previous = previous;
                node.Next = next;
                previous.Next = node;
                if (next != null) next.Previous = node;
            }
        }

        public bool RemoveFirst(out T value) 
        {
            return Remove(First, out value);
        }

        public bool RemoveLast(out T value)
        {
           return Remove(Last, out value);
        }

        public bool Remove(DualLinkedNode<T> node, out T value)
        {
            value = default;
            if (node == null) return false;
            value = node.Content;
            if (First == null) return false;
            if (node == First) First = First.Next;
            else{
                var previous = node.Previous;
                var next = node.Next;
                if(next != null) next.Previous = previous;
                previous.Next = next;
            }
            return true;
        }

    }
}
