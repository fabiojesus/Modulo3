using Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Nodes;
using System.Collections;
using System.Collections.Generic;

namespace Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Lists.Iterators
{
    public class SimpleLinkedListEnum<T> : IEnumerator<T>
    {
        public SimpleLinkedListEnum(SimpleLinkedList<T> list)
        {
            this.list = list;
            this.list.AddFirst(default);
            _current = this.list.First;
        }

        private SimpleLinkedList<T> list;

        private SimpleLinkedNode<T> _current;

        public T Current => _current.Data;

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _current = _current.Next;
            return _current != null;
        }

        public void Reset()
        {
            _current = list.First;
        }

        public void Dispose()
        {
        }
    }
}
