using System.Collections;

namespace DataStructuresDotNet
{
    internal class CircularLinkedListEnumerator<T> : IEnumerator<T>
    {
        private LinkedListNode<T> _current;
        public T Current => _current.Value;
        object IEnumerator.Current => Current;
        public CircularLinkedListEnumerator(LinkedList<T> list)
        {
            _current = list.First;
        }

        public bool MoveNext()
        {
            if (_current == null)
                return false;

            _current = _current.Next ?? _current.List.First; 
            return true;
        }

        public void Reset()
        {
            _current = _current.List.First;
        }

        public void Dispose() { }

        /*public LinkedListNode<T> Next<T>(this LinkedListNode<T> node)
        {
            if (node != null && node.List != null)
            {
                return node.Next ?? node.List.First;
            }
            return null;
        }

        public LinkedListNode<T> Previous<T>(this LinkedListNode<T> node)
        {
            if(node != null && node.List != null)
            {
                return node.Previous ?? node.List.First;
            }

            return null;
        }*/
    }
}
