using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp3
{
    public class Queue <TResource> where TResource : Material
    {
        public QueueItem<TResource> Head;
        public QueueItem<TResource> Tail;
        public void Enqueue(QueueItem<TResource> item)
        {
            if (Head == null && item !=null) 
            {
                Head = Tail = item;
            }
            else if (item != null)
            {
                Tail.NextItem = item;
                Tail = item;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public void Dequeue()
        {
            if (Head != null)
            {
                Head = Head.NextItem;
            }
        }
    }
    public class QueueItem <TResource> where TResource : Material
    {
        public string ResourceName { get; }
        public QueueItem<TResource> NextItem { get; set; }

        public QueueItem(TResource resource )
        {
            ResourceName = resource.Name;
        }

    }
}
