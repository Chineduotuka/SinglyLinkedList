using CoustomLinkedList;
using System;

namespace week2Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLis<string> name = new LinkedLis<string>();
            Console.WriteLine("LINKEDLIST");
            Console.WriteLine();
            name.Add("OSADOLOR");
            name.Add("CHINEDU");
            name.Add("OSADOLOR");
            name.Add("ALVIN");
            name.Add("BEST");
            
            Console.WriteLine("NAMES IN THE LIST ARE: ");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"THE INDEXOF OSADOLOR IS: {name.Indexer("OSADOLOR")}");
            Console.WriteLine($"THE TOTAL MEMBER COUNT IN THE NAME LIST IS: {name.Count}");
            Console.WriteLine($"IS \"ALVIN\" IN THE LIST OF NAMES? : {name.Checks("ALVIN")}");
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("##########################");



            StackLib<string> stack = new StackLib<string>();
            Console.WriteLine("STACK");
            Console.WriteLine();
            stack.StackPush("ALVIN");
            stack.StackPush("BEST");
            stack.StackPush("OSADOLOR");
            stack.StackPush("OTUKA");
            stack.StackPush("LITTLE J");

            Console.WriteLine("MEMBERS OF THE STACK ARE: ");
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine($"STACK SIZE BEFORE POPING IS: {stack.StackArraySize()}");
            Console.WriteLine($"IS THE STACK EMPTY? True/False: {stack.StackIsEmpty()}");
            stack.StackPop();
            Console.WriteLine($"STACK SIZE AFTER POPING: {stack.StackArraySize()}");
            Console.WriteLine($"TOP VALUE IN THE STACK IS: {stack.StackPeek()}");
            Console.WriteLine($"IS STACK EMPTY? True/False: {stack.StackIsEmpty()}");
            Console.WriteLine();
            Console.WriteLine("##########################");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            Queue<string> queues = new Queue<string>();
            Console.WriteLine("QUEUE");
            Console.WriteLine();
            queues.QEnqueue("a");
            queues.QEnqueue("b");
            queues.QEnqueue("c");
            queues.QEnqueue("d");
            queues.QEnqueue("e");
            queues.QEnqueue("f");
            queues.QEnqueue("g");

            foreach (var item in queues)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"SIZE OF THE QUEUE IS: {queues.Qsize()}");
            Console.WriteLine($"ITEM REMOVED(DQUEUED) is : {queues.QDequeue()}");
            Console.WriteLine($"IS QUEUE EMPTY? True/False: {queues.QueueIsEmpty()}");
            Console.WriteLine($"SIZE OF QUEUE AFTER DQUEUE: {queues.Qsize()}");

            Console.ReadLine();




        }
    }
}
