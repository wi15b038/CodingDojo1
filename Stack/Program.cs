using System;



namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CodingDojo_1_wi15b038 - STACK");
            Console.WriteLine();
            Console.WriteLine("__________Creating IntegerStack__________");
            IntStack();
            Console.WriteLine("__________Creating StringStack__________");
            StringStack();

            Console.ReadLine();
            

        }

        static void IntStack()
        {
            Stack<int> test = new Stack<int>();

            test.Push(2);
            test.Push(3);
            Console.WriteLine("- current Peek: {0}", test.Peek());
            test.Push(4);
            Console.WriteLine("- current Peek: {0}", test.Peek());
            Console.WriteLine("- POP (delete current top): {0}", test.Pop());
            Console.WriteLine("- current Peek: {0}", test.Peek());
            test.Push(6);
            test.Push(7);
            test.Push(99);

            Console.WriteLine();



        }

        static void StringStack()
        {
            Stack<string> test = new Stack<string>();

            test.Push("A");
            test.Push("B");
            Console.WriteLine("- current Peek: {0}", test.Peek());
            test.Push("C");
            Console.WriteLine("- current Peek: {0}", test.Peek());
            Console.WriteLine("- POP (delete current top): {0}", test.Pop());
            Console.WriteLine("- current Peek: {0}", test.Peek());
        }
    }
    


}
