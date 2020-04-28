using Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Lists.Iterators;
using Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Lists
{
  
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        public SimpleLinkedList(T first)
        {
            var node = new SimpleLinkedNode<T>(first);
            First = node;
        }

        public SimpleLinkedNode<T> this[int position]
        {
            get
            {
                var current = First;
                for (var i = 0; i <= position; i++)
                {
                    current = current.Next;
                }
                return current;
            }
        }

        public int Length
        {
            get
            {
                var current = First;
                var count = 0;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public void ExecuteOnIteration(Action<SimpleLinkedNode<T>> action)
        {
            var current = First;
            while (current != null)
            {
                action.Invoke(current);
                current = current.Next;
            }
        }

        public void Replace(T old, T @new, bool onlyFirst = false)
        {
            var current = First;
            ExecuteOnIteration((current) => current.Data = (current.Data.Equals(old)) ? @new : current.Data);
        }


        public SimpleLinkedNode<T> First { get; set; }

        public SimpleLinkedNode<T> Last
        {
            get
            {
                var last = First;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                return last;
            }
        }

        public void Add(T data)
        {
            var node = new SimpleLinkedNode<T>(data);
            Last.Next = node;
        }

        public void Add(SimpleLinkedNode<T> node)
        {
            Last.Next = node;
        }

        public void AddFirst(T data)
        {
            var node = new SimpleLinkedNode<T>(data);
            node.Next = First;
            First = node;
        }

        public void AddAfter(T data, SimpleLinkedNode<T> previous)
        {
            var node = new SimpleLinkedNode<T>(data);
            node.Next = previous.Next;
            previous.Next = node;
        }

        public T[] ToArray()
        {
            var current = First;
            var array = new T[Length];
            for (var i = 0; i < Length; i++)
            {
                array[i] = current.Data;
                current = current.Next;
            }
            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T Remove(SimpleLinkedNode<T> node)
        {
            var current = First;
            while (current.Next != node)
            {
                current = current.Next;
            }
            current.Next = node.Next;
            var val = node.Data;
            node = null;
            return val;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SimpleLinkedListEnum<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
