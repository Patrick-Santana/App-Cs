using System;
namespace star
{
    public class newclass
    {
        Position first;

        public void Empilha(object item)
        {
            first = new Position(first, item);
        }

        public object Desempilha()
        {
            if (first == null)
            {
                throw new InvalidOperationException("A pilha Encontra-se vazia");
            }

            object result = first.item;
            first = first.next;
            return result;
        }

        class Position
        {
            public Position next;
            
            public object item;

            public Position(Position next, object item)
            {
                this.next = next;
                this.item = item;
            }
        }

    }
}