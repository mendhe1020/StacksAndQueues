namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks And Queues");

            StackAndQueues list = new StackAndQueues();

            list.Push(56);
            list.Push(30);
            list.Push(70);

            list.Display();

            while (!list.IsEmpty())
            {
                list.Peek();
                list.Pop();
            }


            Queues queues = new Queues();

            queues.Enqueue(56);
            queues.Enqueue(30);
            queues.Enqueue(70);

            queues.Display();

        }
    }
}