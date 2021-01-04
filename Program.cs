using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new newclass();
            s.Empilha(1);
            s.Empilha(100);
            s.Empilha(1000);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            
           
        
        }
    }
}
