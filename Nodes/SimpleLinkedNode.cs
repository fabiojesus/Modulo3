using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Nodes
{
    public class SimpleLinkedNode<T1>
    {
        public T1 Data { get; set; }
        public SimpleLinkedNode<T1> Next { get; set; }

        public SimpleLinkedNode(T1 data)
        {
            Data = data;
        }

    }

}
