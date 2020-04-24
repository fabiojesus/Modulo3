using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Nodes
{
    public class DoubleLinkedNode<T1>
    {
        public T1 Data { get; set; }
        public DoubleLinkedNode<T1> Next { get; set; }
        public DoubleLinkedNode<T1> Previous { get; set; }
    }
}
