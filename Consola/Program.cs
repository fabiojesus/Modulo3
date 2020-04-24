using Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Lists;
using Recodme.Formacao.Modulo3.TiposAbstratosDeDados.Nodes;
using System;
using System.Threading;

namespace Recodme.Formacao.Modulo3.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple Linked
            //var firstNode = new SimpleLinkedNode<string>();
            //firstNode.Data = "primeiro";

            //var secondNode = new SimpleLinkedNode<string>();
            //secondNode.Data = "segundo";

            //var thirdNode = new SimpleLinkedNode<string>();
            //thirdNode.Data = "terceiro";

            //var fourthNode = new SimpleLinkedNode<string>();
            //fourthNode.Data = "quarto";

            //var fifthNode = new SimpleLinkedNode<string>();
            //fifthNode.Data = "quinto";

            //var sixthNode = new SimpleLinkedNode<string>();
            //sixthNode.Data = "sexto";

            //var seventhNode = new SimpleLinkedNode<string>();
            //seventhNode.Data = "quarto";

            //firstNode.Next = secondNode;
            //secondNode.Next = thirdNode;
            //thirdNode.Next = fourthNode;
            //fourthNode.Next = fifthNode;
            //fifthNode.Next = sixthNode;
            //sixthNode.Next = seventhNode;

            //var currentNode = firstNode;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Data);
            //    currentNode = currentNode.Next;
            //}
            #endregion

            #region Circular
            //var firstNode = new SimpleLinkedNode<string>();
            //firstNode.Data = "primeiro";

            //var secondNode = new SimpleLinkedNode<string>();
            //secondNode.Data = "segundo";

            //var thirdNode = new SimpleLinkedNode<string>();
            //thirdNode.Data = "terceiro";

            //var fourthNode = new SimpleLinkedNode<string>();
            //fourthNode.Data = "quarto";

            //var fifthNode = new SimpleLinkedNode<string>();
            //fifthNode.Data = "quinto";

            //var sixthNode = new SimpleLinkedNode<string>();
            //sixthNode.Data = "sexto";



            //firstNode.Next = secondNode;
            //secondNode.Next = thirdNode;
            //thirdNode.Next = fourthNode;
            //fourthNode.Next = fifthNode;
            //fifthNode.Next = sixthNode;
            //sixthNode.Next = firstNode;

            //var currentNode = firstNode;
            //var loop = 0;
            //while (loop<3)
            //{
            //    if(currentNode == firstNode) Console.WriteLine("\nLoop #" + (loop+1));
            //    Console.WriteLine(currentNode.Data);
            //    if (currentNode == sixthNode) loop++;
            //    currentNode = currentNode.Next;
            //}
            #endregion

            #region Back And Forth
            //var firstNode = new DoubleLinkedNode<string>();
            //firstNode.Data = "primeiro";

            //var secondNode = new DoubleLinkedNode<string>();
            //secondNode.Data = "segundo";

            //var thirdNode = new DoubleLinkedNode<string>();
            //thirdNode.Data = "terceiro";

            //var fourthNode = new DoubleLinkedNode<string>();
            //fourthNode.Data = "quarto";

            //var fifthNode = new DoubleLinkedNode<string>();
            //fifthNode.Data = "quinto";

            //var sixthNode = new DoubleLinkedNode<string>();
            //sixthNode.Data = "sexto";

            //firstNode.Next = secondNode;
            //secondNode.Next = thirdNode;
            //thirdNode.Next = fourthNode;
            //fourthNode.Next = fifthNode;
            //fifthNode.Next = sixthNode;

            //secondNode.Previous = firstNode;
            //thirdNode.Previous = secondNode;
            //fourthNode.Previous = thirdNode;
            //fifthNode.Previous = fourthNode;
            //sixthNode.Previous = fifthNode;

            //var currentNode = firstNode;

            //var goBack = false;
            //var loop = 0;
            //while (currentNode != null)
            //{
            //    if (currentNode == firstNode && goBack && loop < 2)
            //    {
            //        goBack = false;
            //        loop++;
            //    }
            //    if (currentNode == firstNode) Console.WriteLine("\nLööp #" + (loop + 1));
            //    Console.WriteLine(currentNode.Data);
            //    if (currentNode == sixthNode) goBack = true;

            //    if (goBack) currentNode = currentNode.Previous;
            //    else currentNode = currentNode.Next;
            //}
            #endregion

            var list = new SimpleLinkedList<string>("First");
            list.Add("Second");
            list.Add("Third");
            list.Add("Forth");
            list.Add("Fifth");
            list.Add("Sixth");
            list.Add("Seventh");
            list.Add("Eighth");
            list.Add("Seventh");
            list.Add("Nineth");
            list.AddFirst("zero");
            list.Replace("Seventh", "Hello");
        }
    }
}
